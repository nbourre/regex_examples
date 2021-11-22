using regex.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.RegularExpressions;

namespace regex.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private string pattern;

        public string Pattern
        {
            get { return pattern; }
            set {
                pattern = value;
                OnPropertyChanged();
            }
        }

        private string testText;

        public string TestText
        {
            get { return testText; }
            set {
                testText = value;
                OnPropertyChanged();
            }
        }

        private string testResult;

        public string TestResult
        {
            get { return testResult; }
            set { 
                testResult = value;
                OnPropertyChanged();
            }
        }


        public DelegateCommand<string> TestRegexCommand { get; set; }

        
        public MainViewModel()
        {
            TestRegexCommand = new DelegateCommand<string>(TestRegEx);
        }

        private void TestRegEx(string obj)
        {
            var regexp = new Regex(Pattern);
            regexp.Match(TestText);

            if (regexp.IsMatch(TestText))
            {
                TestResult = "Good!";
            } else
            {
                TestResult = "Nope!";
            }
        }
    }
}