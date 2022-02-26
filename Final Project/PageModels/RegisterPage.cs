using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project.PageModels
{
    class RegisterPage
    {
        const string createAccountTextSelector = "#tt-pageContent > div > div > h1"; 
        const string firstNameLabelSelector = "#create_customer > div:nth-child(4) > label"; 
        const string firstNameInputSelector = "loginInputName";  // First Name is a * Required Field, but does not have an error message for empty values
        const string lastNameLabelSelector = "#create_customer > div:nth-child(5) > label"; 
        const string lastNameInputSelector = "loginLastName"; // Last Name is a * Required Field, but does not have an error message for empty values
        const string emailLabelSelector = "#create_customer > div:nth-child(6) > label";
        const string emailInputSelector = "loginInputEmail";
        const string emailErrorSelector = "#create_customer > div.tt-base-color > div > ul > li:nth-child(2)";
        const string passwordLabelSelector = "#create_customer > div:nth-child(7) > label";
        const string passwordInputSelector = "loginInputPassword";
        const string passwordErrorSelector = "#create_customer > div.tt-base-color > div > ul > li:nth-child(1)";
        const string createSelector = "#create_customer > div.row > div:nth-child(1) > div > button"; 
        const string returnToStoreSelector = "#create_customer > div.row > div.col-auto.align-self-center > div > ul > li > a"; 
    }
}
