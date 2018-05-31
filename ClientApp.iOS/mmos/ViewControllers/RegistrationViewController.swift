//
//  RegistrationViewController.swift
//  mmos
//
//  Created by 8teRnity on 5/29/18.
//  Copyright © 2018 kpi. All rights reserved.
//

import UIKit

class RegistrationViewController : UIViewController {
    
    @IBOutlet weak var EmailTextField: UITextField!
    
    @IBOutlet weak var PasswordTextField: UITextField!
    
    @IBOutlet weak var ConfirmPasswordTextField: UITextField!
    
    @IBOutlet weak var FirstNameTextField: UITextField!
    
    @IBOutlet weak var LastNameTextField: UITextField!
    
    @IBOutlet weak var PositionSegment: UISegmentedControl!
    
    @IBOutlet weak var SpecializationTextField: UITextField!
    
    @IBOutlet weak var LevelSegment: UISegmentedControl!
    
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view, typically from a nib.
    }
    
    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
        // Dispose of any resources that can be recreated.
    }
    
    @IBAction func onRegisterButtonClick(_ sender: UIButton) {
        
    }
}
