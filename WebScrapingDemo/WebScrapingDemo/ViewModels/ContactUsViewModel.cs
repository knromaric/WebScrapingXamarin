using MvvmHelpers;
using Plugin.Messaging;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace WebScrapingDemo.ViewModels
{
    public class ContactUsViewModel: BaseViewModel
    {
        public Command ContactUsCommand { get; }

        private string _subject;

        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        private string _message;

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }


        public ContactUsViewModel()
        {
            ContactUsCommand = new Command(ContactUsMethod);
        }

        private void ContactUsMethod(object obj)
        {
            var email = CrossMessaging.Current.EmailMessenger; 

            if(email.CanSendEmail)
            {
                email.SendEmail("info@thepower.pk", _subject, _message);
            }
        }
    }
}
