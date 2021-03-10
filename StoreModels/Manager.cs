using System;
namespace StoreModels
{
    public class Manager
    {
        public int id;
        private String managerName;
        private String managerPassword;

        public int Id
        {
            get { return id; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Error. ID cannot be null.");
                }
                id = value;

            }
        }
        public String ManagerName
        {
        get{return managerName;}
        set 
        {
            if(value == null || value.Equals("") ) 
            {throw new ArgumentNullException("Manager name should not be null, try again.");
            } // TODO:
            managerName = value;

        }
    }

    public String ManagerPassword
        {
        get{return managerPassword;}
        set 
        {
            if(value == null || value.Equals("") ) 
            {throw new ArgumentNullException("Manager password should not be null, try again.");
            } // TODO:
            managerPassword = value;

        }
    }

        public override string ToString() => $"The manager {this.ManagerName.ToString()} was found in the system.";
    }
}