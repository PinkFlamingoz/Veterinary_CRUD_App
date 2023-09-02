using Veterinary_CRUD_App.Models;

namespace Veterinary_CRUD_App.Interfaces.Owner
{
    // Declare an internal interface named 'IOwner_Repository_Interface'.
    // This interface inherits from 'IBase_Repository_Interface<Owner_Model>', which means that any class implementing 'IOwner_Repository_Interface' will have to provide implementations for the methods defined in 'IBase_Repository_Interface'.
    internal interface IOwner_Repository_Interface : IBase_Repository_Interface<Owner_Model>
    {
        // FUNCTION DECLARATIONS:

        // Return an IEnumerable of Pet_Model objects for a specific owner
        IEnumerable<Pet_Model> Get_All_Pets_For_Owner(int specific_owner_id);
    }
}