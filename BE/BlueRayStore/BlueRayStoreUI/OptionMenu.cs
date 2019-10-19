namespace BlueRayStoreModel
{
    using System.Collections.Generic;

    public class OptionMenu
    {
        public OptionMenu()
        {
            this.OptionList = new List<string>();
        }

        public List<string> OptionList { get; private set; }

        public bool AddOption(string option)
        {
            if (option == string.Empty)
            {
                return false;
            }

            this.OptionList.Add(option);
            return true;
        }
    }
}
