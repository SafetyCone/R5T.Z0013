using System;


namespace R5T.Z0013
{
	public class OrganizationNamespaceTokens : IOrganizationNamespaceTokens
	{
		#region Infrastructure

	    public static IOrganizationNamespaceTokens Instance { get; } = new OrganizationNamespaceTokens();

	    private OrganizationNamespaceTokens()
	    {
        }

	    #endregion
	}
}