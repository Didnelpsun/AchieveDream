
namespace AchieveDream.Objects
{
    public class Simple
    {
        private int _ID;
        private string _Name;
        public int ID
        {
            set
            {
                _ID = value;
            }
            get
            {
                return _ID;
            }
        }
        public string Name
        {
            set
            {
                _Name = value;
            }
            get
            {
                return _Name;
            }
        }
        public Simple(int id, string name)
        {
            _ID = id;
            _Name = name;
        }
    }
}