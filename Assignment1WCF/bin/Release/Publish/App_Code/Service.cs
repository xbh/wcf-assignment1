using System;
using System.Activities.Statements;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    public string PrimeNumber(int num)
    {
        if (num > 1 && Enumerable.Range(1, num).Where(x => num % x == 0).SequenceEqual(new[] { 1, num }))
        {
            return "Prime Number";
        }
        return "Not Prime Number";
        
    }

    public int SumOfDigits(int num)
    {
        string stringNum = num.ToString();
        int sum = 0;

        foreach (var i in stringNum)
        {
            sum += int.Parse(i.ToString());
        }

        return sum;
    }

    public string ReverseString(string inputString)
    {
        return new string(inputString.Reverse().ToArray());
    }

    public string PrintHtmlTags(string tag, string data)
    {
        return string.Format("<{0}>{1}</{0}>",tag,data);
    }

    public int[] SortNumbers(string type, int[] data)
    {
        switch (type.ToLower())
        {
            case "ascending":
                var ordered = data.OrderBy(x=>x);
                return ordered.ToArray();
            case "descending":
                var orderedDescending = data.OrderByDescending(x => x);
                return orderedDescending.ToArray();
            default:
                throw new Exception("Invalid Option");
        }
        
    }

}
