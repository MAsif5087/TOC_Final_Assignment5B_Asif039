using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class controller : MonoBehaviour
{
    public void openMlagent()
    {

        SceneManager.LoadScene("Penguins");
    }

    public void openComputationalModel()
    {

        SceneManager.LoadScene("ComputationalModels");
    }
    public void openPallandrome()
    {

        SceneManager.LoadScene("Pallandrom");
    }
    public void PallandromeLanuuage()
    {

        SceneManager.LoadScene("Lauguage");
    }
    public void openMatching()
    {

        SceneManager.LoadScene("MatchingParen");
    }
    public void MatchingLanuuage()
    {

        SceneManager.LoadScene("LauguageMP");
    }
    public void PallandromeWorld()
    {

        SceneManager.LoadScene("PalandromeScene");
    }

    public void openCourseLearnt()
    {

        SceneManager.LoadScene("CourseLearnt");
    }
    public void openInstructorWebsite()
    {

        Application.OpenURL("http://www.niazilab.com");
    }
    public void QuiteApp()
    {


        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
    public void return_courseleant()
    {

        SceneManager.LoadScene("MainProject");
    }

    public void matching_world()
    {

        SceneManager.LoadScene("MatchingParantheses");
    }
    public void openPenguine()
    {

        SceneManager.LoadScene("Penguins");
    }
    public void openHummingBird()
    {

        SceneManager.LoadScene("FlowerIseland");
    }
    public void openMLAgents()
    {

        SceneManager.LoadScene("MLAgents");
    }


}
