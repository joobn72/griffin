using System.Data;

namespace Griffin.TestTools.Data
{
    public class FakeParameter : System.Data.Common.DbParameter
    {
        public override void ResetDbType()
        {
            
        }

        public override DbType DbType { get; set; }
        public override ParameterDirection Direction { get; set; }
        public override bool IsNullable { get;  set; }
        public override string ParameterName { get; set; }
        public override string SourceColumn { get; set; }

        public override bool SourceColumnNullMapping { get; set; }

        public override DataRowVersion SourceVersion { get; set; }
        public override object Value { get; set; }
        public byte Precision { get; set; }
        public byte Scale { get; set; }
        public override int Size { get; set; }
    }
}