using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Anna_Baseley_Capstone_2
{
    class Task
    {
        #region DataMemebers
        private string teammatesName;
        private string description;
        private DateTime dueDate;
        private bool completion;

        #endregion

        #region Properties
        public string TeammatesName { get => teammatesName; set => teammatesName = value; }
        public string Description { get => description; set => description = value; }
        public DateTime DueDate { get => dueDate; set => dueDate = value; }
        public bool Completion { get => completion; set => completion = value; }

        #endregion

        #region Constructors
        public Task()
        {
            completion = false;
        }

        public Task(string tN, string desc, DateTime dd)
        {
            TeammatesName = tN;
            Description = desc;
            DueDate = dd;
            Completion = false;
        }
        #endregion

        #region Methods

        #endregion
    }
}
