using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace OCC_New_App
{
    public class SummaryViewModel: ViewModelBase
    {
        #region Properties

        //public List<Azman> az_rules { get; set; }
        public ObservableCollection<Azman> az_rules
        {
            get
            {
                return _az_rules;
            }
        }
        #endregion

        #region Initializing Rules

        private static ObservableCollection<Azman> _az_rules = new ObservableCollection<Azman>(new List<Azman>()
            {
                new Azman()
                {
                    ruleName = 400,
                    ruleDescription = "External Recipients",
                    rulePrivisionDetails = new RuleProvision()
                    {
                        RP_Requestor = "Carlos",
                        RP_GroupName = "gs-operations"
                    }
                },

                new Azman()
                {
                    ruleName = 527,
                    ruleDescription = "Operations Classification",
                    rulePrivisionDetails = new RuleProvision()
                    {
                        RP_Requestor = "Carlos",
                        RP_GroupName = "gs-operations"
                    }
                }
            });
        #endregion

        #region Constructor
        public SummaryViewModel()
        {

        }
        #endregion
    }
}
