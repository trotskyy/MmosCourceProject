﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModelValidation.Abstract;
using DomainModelValidation.Exceptions;
using System.Reflection;

namespace DomainModelValidation
{
    public static class DomainModelValidator<TUnitOfWork>
        where TUnitOfWork : class
    {
        private static bool _isConfigured = false;
        private static object _configureLock = new object();

        private static RulesSet<TUnitOfWork> _onUpdateRulesSet;
        private static RulesSet<TUnitOfWork> _onCreateRulesSet;
        private static RulesSet<TUnitOfWork> _onDeleteRulesSet;


        public static void Validate<TDbEntity>(TDbEntity entity, TUnitOfWork uow, ValidationType validationType)
            where TDbEntity : class
        {
            if (!_isConfigured)
                throw new DomainModelValidatorConfigurationException($"DomainModelValidator for {typeof(TUnitOfWork).Name} data source was not configured");

            if (entity == null)
                throw new ArgumentNullException("entity", "Cannot validate null!");
            if (uow == null)
                throw new ArgumentNullException("uow", $"{typeof(TUnitOfWork)} object must be sent as a parameter");

            var validationAttribute = entity.GetType().GetCustomAttribute<ValidateDomainConstraintsAttribute>();
            if (validationAttribute == null)
                return;

            if ((validationAttribute.GetValidationType() & validationType) != validationType)
                return;

            if (!_isConfigured)
                throw new DomainModelValidatorConfigurationException($"DomainModelValidator for {typeof(TUnitOfWork).Name} is not configured. Configure it in Configure() method"); 

            RulesSet<TUnitOfWork> rulesSet = null;

            switch (validationType)
            {
                case ValidationType.OnUpdate:
                    rulesSet = _onUpdateRulesSet;
                    break;
                case ValidationType.OnCreate:
                    rulesSet = _onCreateRulesSet;
                    break;
                case ValidationType.OnDelete:
                    rulesSet = _onDeleteRulesSet;
                    break;
                default:
                    break;
            }

            if (rulesSet == null)
                throw new RulesSetNotSpecifiedException(
                    $"RulesSet for {validationType.ToString("g")} validation type is not specified. Reconfigure validator");

            var rule = rulesSet.GetValidationRule<TDbEntity>(); 
            if (rule == null)
                throw new ValidationRuleUnregisteredException(
                    $"Validation rule for {typeof(TDbEntity).Name} entity ({validationType.ToString("g")} validation type) is not registered. Reconfigure validator");

            rule.ValidateRule(entity, uow);
        }

        public static void Configure(Action<IDomainModelValidatorConfigurator<TUnitOfWork>> validatorConfigurationExpression)
        {
            lock(_configureLock)
            {
                if (_isConfigured)
                    throw new DomainModelValidatorConfigurationException("DomainModelValidator can be configured only once per AppDomain");

                var cfg = new DomainModelValidatorConfigurator<TUnitOfWork>();
                validatorConfigurationExpression.Invoke(cfg);

                // here
                _onCreateRulesSet = cfg.OnCreateRulesSet;
                _onDeleteRulesSet = cfg.OnDeleteRulesSet;
                _onUpdateRulesSet = cfg.OnUpdateRulesSet;

                _isConfigured = true;
            }
        }
    }
}
