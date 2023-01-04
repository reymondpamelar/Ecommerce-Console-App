using System;
using System.Xml.Linq;

namespace Ecommerce_Console_App
{
	public class User
	{
		//INSTANCE VARIABLES
		private String _firstName;
		private String _lastName;
        private String _location;

		//CONSTRUCTORS
        public User()
		{
			_location = "";
            _firstName = "";
            _lastName = "";
        }

		public User(String firstName, String lastName, String location)
		{
			_firstName = firstName;
			_lastName = lastName;
			_location = location;
		}

        //SETTERS & GETTERS
        public string FirstName
        {
            get => _firstName;
            set
            {
                if (value != null)
                {
                    _firstName = value;
                }
                else
                {
                    throw new ArgumentNullException("Name cannot be null");
                }
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                if (value != null)
                {
                    _lastName = value;
                }
                else
                {
                    throw new ArgumentNullException("Name cannot be null");
                }
            }
        }

        public string Location
        {
            get => _location;
            set
            {
                if (value != null)
                {
                    _location = value;
                }
                else
                {
                    throw new ArgumentNullException("Location cannot be null");
                }
            }
        }
    }
}

