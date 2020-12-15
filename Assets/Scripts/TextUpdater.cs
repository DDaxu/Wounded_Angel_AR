using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TextUpdater : MonoBehaviour
{
    //Calculator text which handles tour progression.
   public TextMeshProUGUI calculatorText;

   public TextMeshProUGUI rdyText;

    //Ongoing quest text
   public TextMeshProUGUI quest;
   public TextMeshProUGUI questHead;
    //images text parts and clickable objects.
   public GameObject kaarmeTeksti;
   public GameObject kaarmeQuad;
   public GameObject kaarmeInfo;
   

   public GameObject kuolemaTeksti;
   public GameObject kuolemaQuad;
    public GameObject kuolemaInfo;
   
   public GameObject lintuTeksti;
   public GameObject lintuQuad;
   public GameObject lintuInfo;

   
   public GameObject jengiTeksti;
   public GameObject jengiQuad;
   public GameObject jengiInfo;



   //insert last part here
   public GameObject enkeliTeksti;
   public GameObject enkeliQuad;
   public GameObject enkeliInfo;
   //booleans for showing and hiding gameobjects.
   bool näkyvä = true;
   bool piilossa = false;
 public void textUpdater(int Laskuri){
     //Snake
     if(Laskuri.ToString() == "1"){
        Debug.Log(Laskuri.ToString());
        //Change next picture to be clickable and set present image text to visible and disable clickable option.
        //change present image settings
        kaarmeTeksti.SetActive(näkyvä);
        kaarmeQuad.SetActive(piilossa);
        kaarmeInfo.SetActive(näkyvä);
        //Change next image settings
        kuolemaQuad.SetActive(näkyvä);
        kuolemaTeksti.SetActive(piilossa);

        //kaarmeInfo.SetActive(näkyvä);
        //Update quest text
        quest.text = "Kirkossa on esillä teos, jossa kuolleet hoitavat eläviä... Etsi kuva!";
        questHead.text = "2. Tehtävä";       
        calculatorText.text = "2";
    //death
     }else if(Laskuri.ToString() == "2"){
        Debug.Log(Laskuri.ToString());
        //Change next picture to be clickable and set present image text to visible and disable clickable option.
        //change present image settings
        kuolemaTeksti.SetActive(näkyvä);
        kuolemaQuad.SetActive(piilossa);
        //Change next image settings
        jengiQuad.SetActive(näkyvä);
        jengiTeksti.SetActive(piilossa);
        kuolemaInfo.SetActive(näkyvä);
        //Update quest text
        quest.text = "Seuraavaksi sinun tulee löytää teos, jonka varmasti kaikki näkevät kerralla!";  
        questHead.text = "3. Tehtävä";    
        calculatorText.text = "3";
    //altar
     }else if(Laskuri.ToString() == "3"){
        Debug.Log(Laskuri.ToString());
        //Change next picture to be clickable and set present image text to visible and disable clickable option.
        //change present image settings
        jengiTeksti.SetActive(näkyvä);
        jengiQuad.SetActive(piilossa);
        //Change next image settings
        lintuQuad.SetActive(näkyvä);
        lintuTeksti.SetActive(piilossa);
        jengiInfo.SetActive(näkyvä);

        //Update quest text
        quest.text = "Seuraava teos päästää kirkkoon valoa mutta koristaa silti kuvillaan. Keskeltä löydät kyyhkysen!";
        questHead.text = "4. Tehtävä";      
        calculatorText.text = "4";
    //bird
     }else if(Laskuri.ToString() == "4"){
        Debug.Log(Laskuri.ToString());
        //Change next picture to be clickable and set present image text to visible and disable clickable option.
        //change present image settings
        lintuTeksti.SetActive(näkyvä);
        lintuQuad.SetActive(piilossa);
        //Change next image settings
        enkeliQuad.SetActive(näkyvä);
        enkeliTeksti.SetActive(piilossa);
        lintuInfo.SetActive(näkyvä);
        //Update quest text
        quest.text = "Viimeinen tehtävä. Kirkon kuuluisin teos. Maalauksessa esiintyy kolme henkilöä, joista yksi ei näe...";
        questHead.text = "5. Tehtävä";      
        calculatorText.text = "5";
    //fallen angel
     }else if(Laskuri.ToString() == "5"){
        //Debug.Log(Laskuri.ToString());
        //Change bunch of stuff here and this is final step
        enkeliTeksti.SetActive(näkyvä);
        enkeliQuad.SetActive(piilossa);
        enkeliInfo.SetActive(näkyvä);
        quest.text = "Suoritit kaikki tehtävät. Kiitoksia vierailusta! Voit vielä kiertää vapaasti katselemassa maalauksia.";
        questHead.text = "Valmista!";      
        calculatorText.text = " ";
        rdyText.text = "  Valmista!";
     }
 }
}
