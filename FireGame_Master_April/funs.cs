using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireGame_Master_April
{
   public class funs
    {

        Random rd = new Random();
        //function generating chances
        public int gen()
        {
            InitializeComponent();
            return rd.Next(1, 7);
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        public int gen2()
        {
            return rd.Next(3, 6);
        }
        //method to generate the sound 
      /*  public void sound()
        {
            System.Media.SoundPlayer obj = new System.Media.SoundPlayer(FireGame_Master_April.Properties.Resources._40_smith_wesson_8x_gunshot_mike_koenig);
            obj.Play();
        }*/

    }

}
