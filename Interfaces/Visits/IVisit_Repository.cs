using Veterinary_CRUD_App.Models;

namespace Veterinary_CRUD_App.Interfaces.Visits
{
    // Declare an internal interface named 'IVisit_Repository_Interface'.
    // This interface inherits from 'IBase_Repository_Interface<Visit_Model>', which means that any class implementing 'IVisit_Repository_Interface' will have to provide implementations for the methods defined in 'IBase_Repository_Interface'.
    internal interface IVisit_Repository_Interface : IBase_Repository_Interface<Visit_Model>
    {
        // FUNCTION DECLARATIONS:

        // Return an IEnumerable of Pet_Model objects.
        IEnumerable<Pet_Model> Get_All_Pets();
    }
}