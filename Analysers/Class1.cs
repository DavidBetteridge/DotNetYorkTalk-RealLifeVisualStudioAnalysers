using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml;
using static PROACTIS.P2P.VB6Conversion.VB6;

namespace Analysers
{
    public class Class1
    {
        public Class1()
        {
            // Built-in with correction
            //dosomething();
        }

        // private void Casts()
        //{
        //// With autocorrection
        //var rs = new PROACTIS.P2P.VB6Conversion.Recordset("");
        //var d = (decimal)rs.Fields["QuantityOrdered"].Value;
        //}

        //private const string mstrCLASS_NAME = "Class2";

        //private void ReadData()
        //{
        //    var cmd = new SqlCommand();
        //    cmd.Parameters.Add("@RecordID");
        //    cmd.Parameters["@Record"].Direction = System.Data.ParameterDirection.Output;

        //    // .. execute command

        //    var value = cmd.Parameters["@Record"].Value;
        //}


        //private void UpdateData(SqlConnection cn)
        //{
        //    using (var tx = new TransactionScope())
        //    {
        //        var cmd = new SqlCommand();
        //        cmd.CommandText = "do something";
        //        cmd.Connection = cn;
        //        cmd.ExecuteNonQuery();
        //    }
        //}

        //private void XML()
        //{
        //    var dom = new XmlDocument();
        //    if (dom.SelectNodes("*") == null)
        //    {
        //        // No data found
        //    }
        //}

        //private bool Conditions()
        //{
        //    var alreadyChecked = true;
        //    return alreadyChecked || Conditions();
        //}

        //void AMethod()
        //{
        //    const string strPROC_NAME = "[" + mstrCLASS_NAME + "]" + "OtherMethod";
        //    const string strPROC_NAME = "OtherMethod";
        //}

        //char iff()
        //{
        //    var Authorise = true;
        //    return IIf(Authorise, 'A', 'R');     //What's the problem with this?  
        //}


        //void guids()
        //{
        //    var g = new Guid("");

        //    var x = new PROACTIS.P2P.grsGeneralUtilities.XML();
        //    var g2 = new Guid(x.GetAttrString(null, "element"));
        //}


        //void datetimes()
        //{
        //    if (DateTime.Now == null)
        //    {

        //    }

        //    DateTime? dt = DateTime.Now;
        //    if (dt == DateTime.MinValue)    //Wrong error message!
        //    {

        //    }

        //}

        //void guids2()
        //{
        //    if (Guid.NewGuid() == null)
        //    {

        //    }


        //    Guid? g = Guid.NewGuid();
        //    if (g == Guid.Empty)
        //    {

        //    }

        //}

        //private void parameters()
        //{
        //    Guid? aValue = Guid.NewGuid();
        //    var cmd = new SqlCommand();
        //    cmd.Parameters.Add("@RecordID");
        //    cmd.Parameters["@RecordID"].Value = aValue;
        //}

        //private void parameters2()
        //{
        //    var cmd = new SqlCommand();
        //    cmd.Parameters.Add("@RecordID", SqlDbType.Int).Value = "Hello";
        //}

        //void guidsAgain()
        //{
        //    var x = new PROACTIS.P2P.grsGeneralUtilities.XML();
        //    var g2 = x.GetAttrString(null, "recordGUID");
        //   // var g3 = x.GetAttrGuid(null, "recordGUID");
        //}

    }
}
