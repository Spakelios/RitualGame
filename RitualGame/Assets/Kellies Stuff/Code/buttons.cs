using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
   public void battleDemon()
   {
      SceneManager.LoadScene("Dungeon Puzzle");
   }

   public void woaha()
   {
      SceneManager.LoadScene("Bast");
   }

   public void amon()
   {
      SceneManager.LoadScene("Amon");
   }

   public void unlock1()
   {
      InfoStorage.DemonUnlock1++;
      SceneManager.LoadScene("menusss");
   }
   
   public void unlock2()
   {
      InfoStorage.DemonUnlock2++;
      SceneManager.LoadScene("menusss");
   }
   
   public void unlock3()
   {
      InfoStorage.DemonUnlock3++;
      SceneManager.LoadScene("menusss");
   }
}
