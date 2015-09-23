using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShoolJournal.Classes.Core;
using System.Text.RegularExpressions;

namespace ShoolJournal.Classes
{
    public class Email
    {
        private readonly string _value;
 
        private Email(string value)
        {
            _value = value;
        }
 
        public static Result<Email> Create(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return Result.Fail<Email>("E-mail can’t be empty");
 
            if (email.Length > 100)
                return Result.Fail<Email>("E-mail is too long");
 
            if (!Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                return Result.Fail<Email>("E-mail is invalid");
 
            return Result.Ok(new Email(email));
        }
 
        public static implicit operator string(Email email)
        {
            return email._value;
        }
 
        public override bool Equals(object obj)
        {
            Email email = obj as Email;
 
            if (ReferenceEquals(email, null))
                return false;
 
            return _value == email._value;
        }
 
        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }
    }

}