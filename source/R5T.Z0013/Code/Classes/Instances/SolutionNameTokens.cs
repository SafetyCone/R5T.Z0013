using System;


namespace R5T.Z0013
{
	public class SolutionNameTokens : ISolutionNameTokens
	{
		#region Infrastructure

	    public static ISolutionNameTokens Instance { get; } = new SolutionNameTokens();

	    private SolutionNameTokens()
	    {
        }

	    #endregion
	}
}