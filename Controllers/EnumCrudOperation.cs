namespace _PrimeiroWebService.Controllers
{
    public enum EnumModelTableType
    {
        UserTable,
        SBOTable
    }

    public enum EnumModelFieldType
    {
        UserField,
        SBOField
    }

    public enum EnumCrudOperation
    {
        Create,
        Retrieve,
        Update,
        Delete
    }
}