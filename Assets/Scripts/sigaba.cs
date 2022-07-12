using System.Collections;
using System.Collections.Generic;
using UnityEngine;

   public class sigaba : MonoBehaviour
{

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
        int[,] rotora = { { 0, 0 }, { 1, 1 }, { 2, 2 }, { 3, 3 }, { 4, 4 }, { 5, 5 }, { 6, 6 }, { 7, 7 }, { 8, 8 }, { 9, 9 } };
        int[,] rotorb = { { 0, 0 }, { 1, 1 }, { 2, 2 }, { 3, 3 }, { 4, 4 }, { 5, 5 }, { 6, 6 }, { 7, 7 }, { 8, 8 }, { 9, 9 } };
        int[,] rotorc = { { 0, 0 }, { 1, 1 }, { 2, 2 }, { 3, 3 }, { 4, 4 }, { 5, 5 }, { 6, 6 }, { 7, 7 }, { 8, 8 }, { 9, 9 } };
        int[,] rotord = { { 0, 0 }, { 1, 1 }, { 2, 2 }, { 3, 3 }, { 4, 4 }, { 5, 5 }, { 6, 6 }, { 7, 7 }, { 8, 8 }, { 9, 9 } };
        int[,] rotore = { { 0, 0 }, { 1, 1 }, { 2, 2 }, { 3, 3 }, { 4, 4 }, { 5, 5 }, { 6, 6 }, { 7, 7 }, { 8, 8 }, { 9, 9 } };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
      void something(string[] args)
    {
        //Control Rotors //need to change
        //stationary
        

        //User input
        // Console.WriteLine("Enter letter");
        // char letter = Console.ReadLine();

        // Cipher Rotor Logic
        //feed user input through cipher rotors
        
        // char swap1 = SearchSwap(rotor1, letter);
        // char swap2 = SearchSwap(rotor2, swap1);
        // char swap3 = SearchSwap(rotor3, swap2);
        // char swap4 = SearchSwap(rotor4, swap3);
        // char swap5 = SearchSwap(rotor5, swap4);
        
        // This section moved to different script
        
        //Control Rotor Logic
        int keystrokes = 0;
        //on every click keystrokes+1;
         Rotate(rotor8);
         if(keystrokes%26 == 0){
         Rotate(rotor7); 
         }
         if(keystrokes%676 == 0){
         Rotate(rotor9);
        }

        //swapping letters through control rotors
        //swap F
        char swapf = LetterSwap('f',rotor6,rotor7,rotor8,rotor9,rotor10);
        //swap G
        char swapg = LetterSwap('g', rotor6, rotor7, rotor8, rotor9, rotor10);
        //swap H
        char swaph = LetterSwap('h', rotor6, rotor7, rotor8, rotor9, rotor10);
        //swap I
        char swapi = LetterSwap('i', rotor6, rotor7, rotor8, rotor9, rotor10);

      //index input logic
       int iil1 = IndexInputLogic(swapf);
       int iil2 = IndexInputLogic(swapg);
       int iil3 = IndexInputLogic(swaph);
       int iil4 = IndexInputLogic(swapi);

      //here pass Indexinputlogicnumbers through index rotors
       int irl1 = IndexRotors(iil1,rotora,rotorb,rotorc,rotord,rotore);
       int irl2 = IndexRotors(iil2, rotora, rotorb, rotorc, rotord, rotore);
       int irl3 = IndexRotors(iil3, rotora, rotorb, rotorc, rotord, rotore);
       int irl4 = IndexRotors(iil4, rotora, rotorb, rotorc, rotord, rotore);

        //index output logic
       int iol1 = IndexOutputLogic(irl1);
       int iol2 = IndexOutputLogic(irl2);
       int iol3 = IndexOutputLogic(irl3);
       int iol4 = IndexOutputLogic(irl4);

        //stepping control
        SteppingControl(iol1,rotor1,rotor2,rotor3,rotor4,rotor5);
        SteppingControl(iol2, rotor1, rotor2, rotor3, rotor4, rotor5);
        SteppingControl(iol3, rotor1, rotor2, rotor3, rotor4, rotor5);
        SteppingControl(iol4, rotor1, rotor2, rotor3, rotor4, rotor5);
    }

    // Rotor Control
    public void RotateRotor7()
    {
        rotor7 = Rotate(rotor7);
    }

    public void RotateRotor8()
    {
        rotor8 = Rotate(rotor8);
    }

    public void RotateRotor9()
    {
        rotor9 = Rotate(rotor9);
    }

    public char Encrypt(char letter)
    {
        char swap1 = SearchSwap(rotor1, letter);
        char swap2 = SearchSwap(rotor2, swap1);
        char swap3 = SearchSwap(rotor3, swap2);
        char swap4 = SearchSwap(rotor4, swap3);
        char swap5 = SearchSwap(rotor5, swap4);
        return swap5;
    }



//Decryption 
char Decrypt(char letter, char[,] r1, char[,] r2, char[,] r3, char[,] r4, char[,] r5)
    {
        char swap1 = SearchSwapDecrypt(r5, letter);
        char swap2 = SearchSwapDecrypt(r4, swap1);
        char swap3 = SearchSwapDecrypt(r3, swap2);
        char swap4 = SearchSwapDecrypt(r2, swap3);
        char swap5 = SearchSwapDecrypt(r1, swap4);
        return swap5;
    }

  //Stepping Control
  //decides which Cipher rotors rotate based on the output from the index output control
     void  SteppingControl(int step, char[,] r1, char[,] r2, char[,] r3, char[,] r4, char[,] r5) {
        if (step == 1)
        {
            Rotate(r1);
        }
        if(step == 2)
        {
            Rotate(r2);
        }
        if(step == 3)
        {
            Rotate(r3);
        }
        if (step == 4)
        {
            Rotate(r4);
        }
        if (step == 5)
        {
            Rotate(r5);
        }
}
//IndexOutputLogic
// input is the outputs of the index rotor bank 
//output is the stepping control rotor number to be changed
  int IndexOutputLogic( int InputNum) {
int input = InputNum; 

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
//
  int IndexInputLogic(char chars) {

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
  int IndexRotors(int indexnumber, int[,] ra, int[,] rb, int[,] rc, int[,] rd, int[,] re) {
        int swapiil1 = IndexSearchSwap(ra,indexnumber);
        int swapiil2 = IndexSearchSwap(rb,swapiil1);
        int swapiil3 = IndexSearchSwap(rc,swapiil2);
        int swapiil4 = IndexSearchSwap(rd,swapiil3);
        int swapiil5 = IndexSearchSwap(re,swapiil4);
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
      char LetterSwap(char letter, char[,] r6, char[,] r7, char[,] r8, char[,] r9, char[,] r10)
    {
        char swap1 = SearchSwap(r6, letter);
        char swap2 = SearchSwap(r7, swap1);
        char swap3 = SearchSwap(r8, swap2);
        char swap4 = SearchSwap(r9, swap3);
        char swap5 = SearchSwap(r10, swap4);
        return swap5;
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


}
