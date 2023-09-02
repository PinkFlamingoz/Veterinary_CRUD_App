namespace Veterinary_CRUD_App.Presenters.Common
{
    // Represents a custom structure for ComboBox items, encapsulating both display Name and an associated ID.
    public class Custom_Combo_Box
    {
        // The display name for the ComboBox item.
        public required string Name { get; set; }

        // The unique identifier for the ComboBox item.
        public int ID { get; set; }

        // Overrides the default ToString method to provide a custom representation for the ComboBox item.
        // The returned string will be in the format: (ID) : Name
        public override string ToString()
        {
            return $"({ID}) : {Name}";
        }
    }
}