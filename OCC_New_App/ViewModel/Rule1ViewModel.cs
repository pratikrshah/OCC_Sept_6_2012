using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCC_New_App
{
    public class Rule1ViewModel
    {
        
        #region Properties
        public List<Rule1Model> rule { get; set; }
        public myCommand ReturnToEditCommand { get; set; }
        public myCommand SendAsIsCommand { get; set; }
        #endregion

        #region Constructor
        public Rule1ViewModel()
        {
            #region Initializing a Rule
            rule = new List<Rule1Model>();

            rule.Add(new Rule1Model()
            {
                topMessage = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                recipients = new List<string> { "pratik@hotmail.com", "pratikrshah@gmail.com" },
                bottomMessage = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                hypLink = "http://www.gs.com",
                blockType = Rule1Model.OCCBlock.SoftBlock
            });
            #endregion

            ReturnToEditCommand = new myCommand(myReturnToEditCommandExecute, myCanReturnToEditCommandExecute);
            SendAsIsCommand = new myCommand(mySendAsIsCommandExecute, myCanSendAsIsCommandExecute);
        }
        #endregion

        private void myReturnToEditCommandExecute(object parameter)
        {

        }

        private bool myCanReturnToEditCommandExecute(object parameter)
        {
            return true;
        }

        private void mySendAsIsCommandExecute(object parameter)
        {

        }

        private bool myCanSendAsIsCommandExecute(object parameter)
        {
            return true;
        }
    }
}
