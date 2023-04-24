using System;


namespace R5T.L0033.Construction
{
    public static partial class Instances
    {
        // Place obsolete instances here to avoid visual distraction in the main instances file.

        [Obsolete("This library rests on the abstraction of project files, not XML. Use one of the project-level abstraction operators instead.")]
        public static L0030.IXmlOperator XmlOperator => L0030.XmlOperator.Instance;
    }
}
