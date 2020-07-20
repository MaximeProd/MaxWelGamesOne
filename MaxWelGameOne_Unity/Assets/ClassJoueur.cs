using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using System.Collections;

namespace Assets
{
    class ClassJoueur
    {
        
        public ClassJoueur()
        {
            
            this.BeginMouvement();
        }
        private void BeginMouvement()
        {
            if (Input.GetKeyDown("space")){
                Debug.Log("Saut");
            }
            if (Input.GetKeyDown("space"))
            {
                Debug.Log("Gauche");
            }
            if (Input.GetKeyDown("space"))
            {
                Debug.Log("Droit");
            }
        }
        
    }
}
