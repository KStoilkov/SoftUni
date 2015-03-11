namespace _03.StudentClass
{
    public class PropertyChangedEventArgs
    {
        public PropertyChangedEventArgs(string propName, string oldValue, string newValue)
        {
            this.PropertyName = propName;
            this.OldValue = oldValue;
            this.NewValue = newValue;
        }

        public string PropertyName { get; set; }

        public string OldValue { get; set; }

        public string NewValue { get; set; }
    }
}
