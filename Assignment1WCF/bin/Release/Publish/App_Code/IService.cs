using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

[ServiceContract]
public interface IService
{

	[OperationContract]
    string PrimeNumber(int num);

    [OperationContract]
    int SumOfDigits(int num);

    [OperationContract]
    string ReverseString(string inputString);

    [OperationContract]
    string PrintHtmlTags(string tag, string data);

    [OperationContract]
    int[] SortNumbers(string type, int[] data);
}

