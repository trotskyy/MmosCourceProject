using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MmosCourseProject.BLL.Utils.DomainModelValidation.Exceptions;

namespace MmosCourseProject.BLL.Utils.DomainModelValidation
{
    public static class DomainModelValidator<TUnitOfWork>
    {
        private static bool _isConfigured = false;
        private static object _configureLock = new object();

        private static RulesSet<TUnitOfWork> _onUpdateRulesSet;
        private static RulesSet<TUnitOfWork> _onCreateRulesSet;
        private static RulesSet<TUnitOfWork> _onDeleteRulesSet;


        public static void Validate<TDbEntity>(TDbEntity entity, TUnitOfWork uow, ValidationType validationType)
        {
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

            var validationAction = rulesSet.ValidationResolver[typeof(TDbEntity)];
            if (validationAction == null)
                throw new ValidationRuleUnregisteredException(
                    $"Validation rule for {typeof(TDbEntity).Name} entity ({validationType.ToString("g")} validation type) is not registered. Reconfigure validator");

            //TODO finish validation logic
            Delegate[] invocationList = validationAction.GetInvocationList();
            foreach (var del in invocationList)
            {
                del.DynamicInvoke(entity, uow);
            }
        }

        public static void Configure(Action<DomainModelValidatorConfigurator<TUnitOfWork>> validatorConfigurationExpression)
        {
            lock(_configureLock)
            {
                if (_isConfigured)
                    throw new DomainModelValidatorConfigurationException("DomainModelValidator can be configured only once per AppDomain");

                var cfg = new DomainModelValidatorConfigurator<TUnitOfWork>(_onUpdateRulesSet, _onDeleteRulesSet, _onCreateRulesSet);
                validatorConfigurationExpression.Invoke(cfg);

                _isConfigured = true;
            }
        }
    }
}
