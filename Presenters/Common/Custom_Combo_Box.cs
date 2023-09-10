namespace Veterinary_CRUD_App.Presenters.Common
{
    // Represents a custom structure for Combo Box items, encapsulating both display Name and an associated ID.
    public class Custom_Combo_Box
    {
        // The display name for the Combo Box item.
        public string Name { get; set; }

        // The unique identifier for the Comb oBox item.
        public int Id { get; set; }

        // Overrides the default ToString method to provide a custom representation for the Combo Box item.
        // The returned string will be in the format: (ID) : Name
        public override string ToString()
        {
            return $"({Id}) : {Name}";
        }
    }
}