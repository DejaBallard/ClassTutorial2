using System;

namespace Version_2_C
{
    [Serializable()]
    public class clsSculpture : clsWork
    {
        public delegate void LoadSculptureFormDelegate(clsSculpture prSculpture);
        public static LoadSculptureFormDelegate LoadSculptureForm;
        private float _Weight;
        private string _Material;

        [NonSerialized()]
        private frmSculpture _SculptureDialog = frmSculpture.Instance;

        public override void EditDetails()
        {
            LoadSculptureForm(this);
        }

        public Single Weight
        {
            get { return _Weight; }
            set { _Weight = value; }
        }

        public string Material
        {
            get { return _Material; }
            set { _Material = value; }
        }
    }
}
