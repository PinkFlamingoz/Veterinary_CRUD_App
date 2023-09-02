using Veterinary_CRUD_App.Models;

namespace Veterinary_CRUD_App.Interfaces.Pets
{
    // Interface 'IPet_Repository_Interface' represents a contract for the repository layer specific to pets.
    // This interface inherits from 'IBase_Repository_Interface<Pet_Model>', which means that any class implementing 'IVisit_Repository_Interface' will have to provide implementations for the methods defined in 'IBase_Repository_Interface'.
    internal interface IPet_Repository_Interface : IBase_Repository_Interface<Pet_Model>
    {
        // FUNCTION DECLARATIONS:

        // Return an IEnumerable of Owner_Model objects
        IEnumerable<Owner_Model> Get_All_Owners();

        // Return an IEnumerable of Visit_Model objects for a specific pet
        IEnumerable<Visit_Model> Get_All_Visits_For_Pet(int specific_pet_id);
    }
}