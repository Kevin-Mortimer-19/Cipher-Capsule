using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sigaba : MonoBehaviour
{

    public SimManager manager;

    char[,] rotor6 = { { 'a', 'q' }, { 'b', 'f' }, { 'c', 'o' }, { 'd', 'v' }, { 'e', 'p' }, { 'f', 'z' }, { 'g', 't' }, { 'h', 'd' }, { 'i', 'k' }, { 'j', 'm' }, { 'k', 'w' }, { 'l', 'a' }, { 'm', 'g' }, { 'n', 'b' }, { 'o', 'u' }, { 'p', 'x' }, { 'q', 'i' }, { 'r', 'h' }, { 's', 'r' }, { 't', 'c' }, { 'u', 'y' }, { 'v', 's' }, { 'w', 'n' }, { 'x', 'j' }, { 'y', 'e' }, { 'z', 'l' } };
    //medium
    char[,] rotor7 = { { 'a', 'l' }, { 'b', 'd' }, { 'c', 'v' }, { 'd', 'q' }, { 'e', 'h' }, { 'f', 's' }, { 'g', 'w' }, { 'h', 'z' }, { 'i', 'g' }, { 'j', 'f' }, { 'k', 'e' }, { 'l', 'y' }, { 'm', 't' }, { 'n', 'c' }, { 'o', 'r' }, { 'p', 'i' }, { 'q', 'p' }, { 'r', 'o' }, { 's', 'b' }, { 't', 'j' }, { 'u', 'x' }, { 'v', 'k' }, { 'w', 'n' }, { 'x', 'a' }, { 'y', 'u' }, { 'z', 'm' } };
    //fast
    char[,] rotor8 = { { 'a', 'y' }, { 'b', 'u' }, { 'c', 'd' }, { 'd', 'e' }, { 'e', 't' }, { 'f', 'f' }, { 'g', 'b' }, { 'h', 'k' }, { 'i', 'w' }, { 'j', 'o' }, { 'k', 's' }, { 'l', 'v' }, { 'm', 'm' }, { 'n', 'r' }, { 'o', 'g' }, { 'p', 'x' }, { 'q', 'i' }, { 'r', 'n' }, { 's', 'q' }, { 't', 'l' }, { 'u', 'a' }, { 'v', 'z' }, { 'w', 'j' }, { 'x', 'h' }, { 'y', 'p' }, { 'z', 'c' } };
    //slow
    char[,] rotor9 = { { 'a', 'c' }, { 'b', 'j' }, { 'c', 's' }, { 'd', 'g' }, { 'e', 'x' }, { 'f', 'o' }, { 'g', 'q' }, { 'h', 'p' }, { 'i', 'd' }, { 'j', 'w' }, { 'k', 'r' }, { 'l', 'l' }, { 'm', 'f' }, { 'n', 'z' }, { 'o', 'y' }, { 'p', 'a' }, { 'q', 'e' }, { 'r', 'n' }, { 's', 'v' }, { 't', 'i' }, { 'u', 'm' }, { 'v', 'k' }, { 'w', 'h' }, { 'x', 'b' }, { 'y', 'u' }, { 'z', 't' } };
    //stationary
    char[,] rotor10 = { { 'a', 'h' }, { 'b', 'b' }, { 'c', 'y' }, { 'd', 'w' }, { 'e', 'p' }, { 'f', 'm' }, { 'g', 'c' }, { 'h', 'i' }, { 'i', 'j' }, { 'j', 'a' }, { 'k', 'z' }, { 'l', 'o' }, { 'm', 'k' }, { 'n', 'v' }, { 'o', 's' }, { 'p', 'r' }, { 'q', 'e' }, { 'r', 'f' }, { 's', 'd' }, { 't', 'n' }, { 'u', 'g' }, { 'v', 'q' }, { 'w', 'l' }, { 'x', 'x' }, { 'y', 't' }, { 'z', 'u' } };

    //Cipher Rotors
    char[,] rotor1 = { { 'a', 'd' }, { 'b', 'g' }, { 'c', 'h' }, { 'd', 'j' }, { 'e', 'l' }, { 'f', 'q' }, { 'g', 'a' }, { 'h', 'p' }, { 'i', 'v' }, { 'j', 'z' }, { 'k', 'w' }, { 'l', 'b' }, { 'm', 'y' }, { 'n', 'u' }, { 'o', 'c' }, { 'p', 't' }, { 'q', 'm' }, { 'r', 'i' }, { 's', 'x' }, { 't', 'e' }, { 'u', 'o' }, { 'v', 'n' }, { 'w', 'f' }, { 'x', 'r' }, { 'y', 's' }, { 'z', 'k' } };
    char[,] rotor2 = { { 'a', 'e' }, { 'b', 'c' }, { 'c', 'v' }, { 'd', 's' }, { 'e', 'g' }, { 'f', 'n' }, { 'g', 'h' }, { 'h', 'x' }, { 'i', 'i' }, { 'j', 'w' }, { 'k', 'o' }, { 'l', 'l' }, { 'm', 'a' }, { 'n', 't' }, { 'o', 'r' }, { 'p', 'y' }, { 'q', 'm' }, { 'r', 'k' }, { 's', 'd' }, { 't', 'b' }, { 'u', 'p' }, { 'v', 'q' }, { 'w', 'z' }, { 'x', 'f' }, { 'y', 'j' }, { 'z', 'u' } };
    char[,] rotor3 = { { 'a', 'v' }, { 'b', 'u' }, { 'c', 'b' }, { 'd', 'y' }, { 'e', 'w' }, { 'f', 'f' }, { 'g', 'e' }, { 'h', 't' }, { 'i', 'z' }, { 'j', 'j' }, { 'k', 'i' }, { 'l', 'o' }, { 'm', 'g' }, { 'n', 'l' }, { 'o', 'a' }, { 'p', 'h' }, { 'q', 'c' }, { 'r', 'k' }, { 's', 'd' }, { 't', 'p' }, { 'u', 'r' }, { 'v', 'n' }, { 'w', 's' }, { 'x', 'q' }, { 'y', 'x' }, { 'z', 'm' } };
    char[,] rotor4 = { { 'a', 's' }, { 'b', 't' }, { 'c', 'z' }, { 'd', 'v' }, { 'e', 'e' }, { 'f', 'r' }, { 'g', 'a' }, { 'h', 'k' }, { 'i', 'h' }, { 'j', 'm' }, { 'k', 'd' }, { 'l', 'p' }, { 'm', 'i' }, { 'n', 'q' }, { 'o', 'b' }, { 'p', 'w' }, { 'q', 'f' }, { 'r', 'x' }, { 's', 'c' }, { 't', 'j' }, { 'u', 'n' }, { 'v', 'o' }, { 'w', 'l' }, { 'x', 'g' }, { 'y', 'y' }, { 'z', 'u' } };
    char[,] rotor5 = { { 'a', 'n' }, { 'b', 'x' }, { 'c', 'y' }, { 'd', 'd' }, { 'e', 'o' }, { 'f', 'p' }, { 'g', 'b' }, { 'h', 'l' }, { 'i', 'v' }, { 'j', 'u' }, { 'k', 'q' }, { 'l', 'j' }, { 'm', 'r' }, { 'n', 'w' }, { 'o', 'k' }, { 'p', 'f' }, { 'q', 't' }, { 'r', 'e' }, { 's', 'h' }, { 't', 'a' }, { 'u', 'g' }, { 'v', 'c' }, { 'w', 'z' }, { 'x', 'm' }, { 'y', 'i' }, { 'z', 's' } };

    //Index Rotors
    int[,] rotora = { { 7, 7 }, { 8, 8 }, { 9, 9 }, { 0, 0 }, { 1, 1 }, { 2, 2 }, { 3, 3 }, { 4, 4 }, { 5, 5 }, { 6, 6 } };
    int[,] rotorb = { { 5, 5 }, { 6, 6 }, { 7, 7 }, { 8, 8 }, { 9, 9 }, { 0, 0 }, { 1, 1 }, { 2, 2 }, { 3, 3 }, { 4, 4 } };
    int[,] rotorc = { { 6, 6 }, { 7, 7 }, { 8, 8 }, { 9, 9 }, { 0, 0 }, { 1, 1 }, { 2, 2 }, { 3, 3 }, { 4, 4 }, { 5, 5 } };
    int[,] rotord = { { 3, 3 }, { 4, 4 }, { 5, 5 }, { 6, 6 }, { 7, 7 }, { 8, 8 }, { 9, 9 }, { 0, 0 }, { 1, 1 }, { 2, 2 } };
    int[,] rotore = { { 8, 8 }, { 9, 9 }, { 0, 0 }, { 1, 1 }, { 2, 2 }, { 3, 3 }, { 4, 4 }, { 5, 5 }, { 6, 6 }, { 7, 7 } };

    char[,] rotor1_d = new char[26,2];
    char[,] rotor2_d = new char[26,2];
    char[,] rotor3_d = new char[26,2];
    char[,] rotor4_d = new char[26,2];
    char[,] rotor5_d = new char[26,2];
    char[,] rotor6_d = new char[26,2];
    char[,] rotor7_d = new char[26,2];
    char[,] rotor8_d = new char[26,2];
    char[,] rotor9_d = new char[26,2];
    char[,] rotor10_d = new char[26,2];
    int[,] rotora_d = new int[10,2];
    int[,] rotorb_d = new int[10,2];
    int[,] rotorc_d = new int[10,2];
    int[,] rotord_d = new int[10,2];
    int[,] rotore_d = new int[10,2];

    void Start() 
    {
        char[,] rotor1_d = (char[,]) rotor1.Clone();
        char[,] rotor2_d = (char[,]) rotor2.Clone();
        char[,] rotor3_d = (char[,]) rotor3.Clone();
        char[,] rotor4_d = (char[,]) rotor4.Clone();
        char[,] rotor5_d = (char[,]) rotor5.Clone();
        char[,] rotor6_d = (char[,]) rotor6.Clone();
        char[,] rotor7_d = (char[,]) rotor7.Clone();
        char[,] rotor8_d = (char[,]) rotor8.Clone();
        char[,] rotor9_d = (char[,]) rotor9.Clone();
        char[,] rotor10_d = (char[,]) rotor10.Clone();
        int[,] rotora_d = (int[,]) rotora.Clone();
        int[,] rotorb_d = (int[,]) rotorb.Clone();
        int[,] rotorc_d = (int[,]) rotorc.Clone();
        int[,] rotord_d = (int[,]) rotord.Clone();
        int[,] rotore_d = (int[,]) rotore.Clone();
    }

    public void ResetRotors()
    {
        char[,] rotor1 = (char[,]) rotor1_d.Clone();
        char[,] rotor2 = (char[,]) rotor2_d.Clone();
        char[,] rotor3 = (char[,]) rotor3_d.Clone();
        char[,] rotor4 = (char[,]) rotor4_d.Clone();
        char[,] rotor5 = (char[,]) rotor5_d.Clone();
        char[,] rotor6 = (char[,]) rotor6_d.Clone();
        char[,] rotor7 = (char[,]) rotor7_d.Clone();
        char[,] rotor8 = (char[,]) rotor8_d.Clone();
        char[,] rotor9 = (char[,]) rotor9_d.Clone();
        char[,] rotor10 = (char[,]) rotor10_d.Clone();
        int[,] rotora = (int[,]) rotora_d.Clone();
        int[,] rotorb = (int[,]) rotorb_d.Clone();
        int[,] rotorc = (int[,]) rotorc_d.Clone();
        int[,] rotord = (int[,]) rotord_d.Clone();
        int[,] rotore = (int[,]) rotore_d.Clone();
    }


    public void UpdateRotors()
    {
        //Control Rotors //need to change
        //stationary

        //swapping letters through control rotors
        //swap F
        char swapf = LetterSwap('f');
        //swap G
        char swapg = LetterSwap('g');
        //swap H
        char swaph = LetterSwap('h');
        //swap I
        char swapi = LetterSwap('i');

        //index input logic
        int iil1 = IndexInputLogic(swapf);
        int iil2 = IndexInputLogic(swapg);
        int iil3 = IndexInputLogic(swaph);
        int iil4 = IndexInputLogic(swapi);

        bool flag2 = true;
        bool flag3 = true;
        bool flag4 = true;

        int irl2 = 0;
        int irl3 = 0;
        int irl4 = 0;
        int iol2 = 0;
        int iol3 = 0;
        int iol4 = 0;

        //here pass Indexinputlogicnumbers through index rotors
        int irl1 = IndexRotors(iil1);
        if(iil2 != iil1)
        {
            irl2 = IndexRotors(iil2);
        } 
        else 
        {
            flag2 = false;
        }
        if(iil3 != iil1 && iil3 != iil2)
        {
            irl3 = IndexRotors(iil3);
        } 
        else 
        {
            flag3 = false;
        }
        if(iil4 != iil1 && iil4 != iil2 && iil4 != iil3)
        {
            irl4 = IndexRotors(iil4);
        } 
        else 
        {
            flag4 = false;
        }
       
        //index output logic
        int iol1 = IndexOutputLogic(irl1);
        if(flag2)
        {
            iol2 = IndexOutputLogic(irl2);
        }
        if(flag3)
        {
            iol3 = IndexOutputLogic(irl3);
        }
        if(flag4)
        {
            iol4 = IndexOutputLogic(irl4);
        }

        if(iol2 == iol1)
        {
            flag2 = false;
        }
        if(iol3 == iol1 || iol3 == iol2)
        {
            flag3 = false;
        }
        if(iol4 == iol1 || iol4 == iol2 || iol4 == iol3)
        {
            flag4 = false;
        }

        //stepping control
        SteppingControl(iol1);
        if(flag2){
            SteppingControl(iol2);
        }
        if(flag3){
            SteppingControl(iol3);
        }
        if(flag4){
            SteppingControl(iol4);
        }

    }

    // Rotor Control
    public void RotateRotor7()
    {
        rotor7 = Rotate(rotor7);
        AnimateRotor(7);
    }

    public void RotateRotor8()
    {
        rotor8 = Rotate(rotor8);
        AnimateRotor(8);
    }

    public void RotateRotor9()
    {
        rotor9 = Rotate(rotor9);
        AnimateRotor(9);
    }

    public char Encrypt(char letter)
    {
        int offset = (int) 'a';

        char swap1 = SearchSwap(rotor1, letter);
        int swap2 = SearchByPosition(rotor2, swap1);
        int swap3 = SearchByPosition(rotor3, (char) (swap2 + offset));
        int swap4 = SearchByPosition(rotor4, (char) (swap3 + offset));
        int swap5 = SearchByPosition(rotor5, (char) (swap4 + offset));
        return (char) (swap5 + offset);
    }



//Decryption 
public char Decrypt(char letter)
    {
        int offset = (int) 'a';

        char swap1 = SearchSwapDecrypt(rotor5, letter);
        int swap2 = SearchByPositionDecrypt(rotor4, swap1);
        int swap3 = SearchByPositionDecrypt(rotor3, (char) (swap2 + offset));
        int swap4 = SearchByPositionDecrypt(rotor2, (char) (swap3 + offset));
        int swap5 = SearchByPositionDecrypt(rotor1, (char) (swap4 + offset));
        return (char) (swap5 + offset);
    }

  //Stepping Control
  //decides which Cipher rotors rotate based on the output from the index output control
    void  SteppingControl(int step) {
        if (step == 1)
        {
            rotor1 = Rotate(rotor1);
            AnimateRotor(1);
        }
        if(step == 2)
        {
            rotor2 = Rotate(rotor2);
            AnimateRotor(2);
        }
        if(step == 3)
        {
            rotor3 = Rotate(rotor3);
            AnimateRotor(3);
        }
        if (step == 4)
        {
            rotor4 = Rotate(rotor4);
            AnimateRotor(4);
        }
        if (step == 5)
        {
            rotor5 = Rotate(rotor5);
            AnimateRotor(5);
        }
}
//IndexOutputLogic
// input is the outputs of the index rotor bank 
//output is the stepping control rotor number to be changed
    int IndexOutputLogic( int InputNum) 
    {
        int input = InputNum + 1; 

        if(input==1||input==10){
            return 1;
        }
        if(input==8||input==9){
            return 2;
        }
        if(input==6||input==7){
            return 3;
        }
        if(input==4||input==5){
            return 4;
        }
        if(input==2||input==3){
            return 5;
        }
        return 0;
    }


//input letter 
//output input # that letter corresponds to 
    int IndexInputLogic(char chars) 
    {
        if (chars == 'b') {
            return 2; 
        }
        if (chars == 'c') {
            return 3; 
        }
        if (chars ==   'd' || chars == 'e') {
            return 4; 
        }
        if (chars ==   'f' || chars ==  'g' || chars ==  'h'){
            return 5; 
        }
        if (chars ==   'i' ||  chars == 'j' ||  chars == 'k') {
            return 6; 
        }
        if (chars ==  'l' || chars == 'm' || chars == 'n' || chars == 'o') {
            return 7; 
        }
        if (chars ==  'p' || chars == 'q' ||  chars =='r' || chars == 's' || chars == 't') {
            return 8; 
        }
        if (chars ==  'u' ||  chars == 'v' || chars ==  'w' || chars ==  'x' || chars == 'y' || chars == 'z'){
            return 9; 
        }
        if (chars ==  'a') {
            return 10; 
        }
        return 0;
    }

 //Index rotors swap a number through index rotor arrays
    int IndexRotors(int indexnumber) {
        int swapiil1 = IndexSearchSwap(rotora,indexnumber);
        int swapiil2 = IndexSwap(rotorb,swapiil1);
        int swapiil3 = IndexSwap(rotorc,swapiil2);
        int swapiil4 = IndexSwap(rotord,swapiil3);
        int swapiil5 = IndexSwap(rotore,swapiil4);
        return swapiil5;
    }


// search double array only on x axis for a
// character then returns the y
    char SearchSwap(char[,] arr, char target)
    {      
        for (int i = 0; i < 26; i++) {
                if (arr[i,0] == target) {
                    return arr[i,1];
                }
        }
        return '-';
    }
    // search double array only on x axis for a
    // character then returns the y
    char SearchSwapDecrypt(char[,] arr, char target)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            if (arr[i,1] == target)
            {
                return arr[i, 0];
            }
        }
        return '-';
    }
    //swap letter through control rotors
    char LetterSwap(char letter)
    {
        int offset = (int) 'a';

        char swap1 = SearchSwap(rotor6, letter);
        int swap2 = SearchByPosition(rotor7, swap1);
        int swap3 = SearchByPosition(rotor8, (char) (swap2 + offset));
        int swap4 = SearchByPosition(rotor9, (char) (swap3 + offset));
        int swap5 = SearchByPosition(rotor10, (char) (swap4 + offset));
        return (char) (swap5 + offset);
    }

    int IndexSearchSwap(int[,] arr, int target)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            if (arr[i, 0] == target)
            {
                return arr[i, 1];
            }
        }
        return '-';
    }


    int IndexSwap(int[,] arr, int target)
    {
        return arr[target, 1];
    }

    char[,] Rotate(char[,] arr)
    {
        char[,] newarr = new char[26, 26];
        char[,] temp = new char[1, 1];

        for (int i = 0; i <= 24; i++)
        {
            newarr[i + 1, 0] = arr[i, 0];
            newarr[i + 1, 1] = arr[i, 1];
        }
        newarr[0, 0] = arr[25, 0];
        newarr[0, 1] = arr[25, 1];

        return newarr;
    }

    public void printArray(char[,] arr)
    {
    for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                print(arr[i,j]);
            }
        }
    }

    public int SearchByPosition(char[,] arr, char c)
    {
        int offset = (int) 'a';
        for (int i = 0; i < 26; i++) {
            if (arr[i,0] == c) {
                return (int) arr[i,1] - offset;
            }
        }
        return -1;
    }

    public int SearchByPositionDecrypt(char[,] arr, char c)
    {
        int offset = (int) 'a';
        for (int i = 0; i < 26; i++) {
            if (arr[i,1] == c) {
                return (int) arr[i,0] - offset;
            }
        }
        return -1;
    }

    void AnimateRotor(int spin_rotor)
    {
        manager.Spin(spin_rotor);
    }
}
