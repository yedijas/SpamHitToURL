using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SpamHitToURL.Models
{
    public class XMLProcessorHelper
    {
        public string SampleFileName { get; set; }
        public XDocument XMLDoc {get;set;}
        public int Index { get; set; }
        private const string AERTCode = "510";
        private const string CTCode = "010";
        private bool AER;
        private List<AccountBICPair> AccountNumList = new List<AccountBICPair>();

        public XMLProcessorHelper(int _index, string _sampleFileName, bool _aerct)
        {
            SampleFileName = _sampleFileName;
            XMLDoc = XDocument.Load(SampleFileName);
            Index = _index;
            AER = _aerct;
            AccountNumList.Add(new AccountBICPair { AccNum = "2571075557", BICCode = "CENAIDJA" });
            AccountNumList.Add(new AccountBICPair { AccNum = "1401500136681", BICCode = "BTANIDJA" });
            AccountNumList.Add(new AccountBICPair { AccNum = "020601000117502", BICCode = "BRINIDJA" });
            AccountNumList.Add(new AccountBICPair { AccNum = "3320068110", BICCode = "DBSBIDJA" });
            AccountNumList.Add(new AccountBICPair { AccNum = "7095560835", BICCode = "BSMDIDJA" });
        }

        public void ReplaceAllParamsInXML()
        {
            string bizMsgIdr = DateTime.Now.ToString("yyyyMMdd") + "CITIIDJX" + (AER? AERTCode: CTCode) + "O01" + Index.ToString("00000000");
            string msgId = DateTime.Now.ToString("yyyyMMdd") + "CITIIDJX" + (AER ? AERTCode : CTCode) + Index.ToString("00000000");

            // replace IDs
            var BizMsgIdr = XMLDoc.Element("BusMsg").Descendants("BizMsgIdr").Single();
            var EndToEndId = XMLDoc.Element("BusMsg").Descendants("EndToEndId").Single();
            var MsgId = XMLDoc.Element("BusMsg").Descendants("MsgId").Single();
            var TxId = XMLDoc.Element("BusMsg").Descendants("TxId").Single();

            BizMsgIdr.Value = bizMsgIdr;
            EndToEndId.Value = bizMsgIdr;
            MsgId.Value = msgId;
            TxId.Value = msgId;

            // replace bank code
            var FinInstnId = XMLDoc.Element("BusMsg").Descendants("To").Single().Descendants("FinInstnId").Single().Descendants("Id").Single();
            var CdtrAgt = XMLDoc.Element("BusMsg").Descendants("CdtrAgt").Single().Descendants("FinInstnId").Single().Descendants("Id").Single();

            FinInstnId.Value = AccountNumList.ElementAt(Index % 5).BICCode;
            CdtrAgt.Value = AccountNumList.ElementAt(Index % 5).BICCode;

            // replace acc num
            var CdtrAcct = XMLDoc.Element("BusMsg").Descendants("CdtrAcct").Single().Descendants("Othr").Single().Descendants("Id").Single();

            CdtrAcct.Value = AccountNumList.ElementAt(Index % 5).AccNum;
        }
    }
}
