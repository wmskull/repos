namespace lab_7
{
    public class Author
    {
        private string name ;

        private char gender;

        private string email;

        

        public Author(string tempName,char tempGender,string tempEmail)
        {
            name = tempName;

            gender = tempGender;

            email = tempEmail;
        }

        public string GetName()
        {
            return name; 
        }
    
        public void SetName(string tempname)
        {
            name = tempname;
        }

        public char  GetGender()
        {
            return gender; 
        }

        public void SetGender(char tempgender)
        {
            gender = tempgender;
        }

        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string tempEmail)
        {
            email = tempEmail;
        }
      
      
      public override string ToString()
        {
            return ("name = " + this.GetName()+ ", email = " + this.GetEmail()+ ", gender = " + this.GetGender());

            
        }

    
    
    
    
    }
}