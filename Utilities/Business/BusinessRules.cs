using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)
        {
            //List<IResult> results = new List<IResult>();
            foreach (var logic in logics)
            {
                if (!logic.IsSuccess)
                {
                    return logic;
                    //results.Add(logic);
                }
            }
            return null;
        }
    }
}
