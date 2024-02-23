using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;
using System.IO.Ports;
public class ConsolData : MonoBehaviour
{
    SerialPort data_stream = new SerialPort("COM9", 115200); //maybe faster later
    public GameObject zero;
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;
    public GameObject six;
    public GameObject seven;
    public GameObject eight;
    public GameObject nine;
    public GameObject ten;
    public GameObject eleven;
    public GameObject twelve;
    public GameObject thirteen;
    public GameObject fourteen;
    public GameObject fifteen;
    public GameObject sixteen;
    public GameObject seventeen;
    public GameObject eighteen;
    public GameObject nineteen;
    public GameObject twenty;
    public GameObject twentyone;
    public GameObject twentytwo;
    public GameObject twentythree;
    public GameObject twentyfour;
    public GameObject twentyfive;
    public GameObject twentysix;
    public GameObject twentyseven;
    public GameObject twentyeight;
    public GameObject twentynine;
    private cube Light0;
    private location1 Light1;
    private loc2 Light2;
    private loc3 Light3;
    private loc4 Light4;
    private loc5 Light5;
    private loc6 Light6;
    private loc7 Light7;
    private loc8 Light8;
    private loc9 Light9;
    private loc10 Light10;
    private loc11 Light11;
    private loc12 Light12;
    private loc13 Light13;
    private loc14 Light14;
    private loc15 Light15;
    private loc16 Light16;
    private loc17 Light17;
    private loc18 Light18;
    private loc19 Light19;
    private loc20 Light20;
    private loc21 Light21;
    private loc22 Light22;
    private loc23 Light23;
    private loc24 Light24;
    private loc25 Light25;
    private loc26 Light26;
    private loc27 Light27;
    private loc28 Light28;
    private loc29 Light29;
    public bool LED0;
    public bool LED1;
    public bool LED2;
    public bool LED3;
    public bool LED4;
    public bool LED5;
    public bool LED6;
    public bool LED7;
    public bool LED8;
    public bool LED9;
    public bool LED10;
    public bool LED11;
    public bool LED12;
    public bool LED13;
    public bool LED14;
    public bool LED15;
    public bool LED16;
    public bool LED17;
    public bool LED18;
    public bool LED19;
    public bool LED20;
    public bool LED21;
    public bool LED22;
    public bool LED23;
    public bool LED24;
    public bool LED25;
    public bool LED26;
    public bool LED27;
    public bool LED28;
    public bool LED29;
    // Start is called before the first frame update
    
    void Start()
    {
        data_stream.Open();
        Light0 = zero.GetComponent<cube>();
        Light1 = one.GetComponent<location1>();
        Light2 = two.GetComponent<loc2>();
        Light3 = three.GetComponent<loc3>();
        Light4 = four.GetComponent<loc4>();
        Light5 = five.GetComponent<loc5>();
        Light6 = six.GetComponent<loc6>();
        Light7 = seven.GetComponent<loc7>();
        Light8 = eight.GetComponent<loc8>();
        Light9 = nine.GetComponent<loc9>();
        Light10 = ten.GetComponent<loc10>();
        Light11 = eleven.GetComponent<loc11>();
        Light12 = twelve.GetComponent<loc12>();
        Light13 = thirteen.GetComponent<loc13>();
        Light14 = fourteen.GetComponent<loc14>();
        Light15 = fifteen.GetComponent<loc15>();
        Light16 = sixteen.GetComponent<loc16>();
        Light17 = seventeen.GetComponent<loc17>();
        Light18= eighteen.GetComponent<loc18>();
        Light19 = nineteen.GetComponent<loc19>();
        Light20 = twenty.GetComponent<loc20>();
        Light21 = twentyone.GetComponent<loc21>();
        Light22 = twentytwo.GetComponent<loc22>();
        Light23 = twentythree.GetComponent<loc23>();
        Light24 = twentyfour.GetComponent<loc24>();
        Light25 = twentyfive.GetComponent<loc25>();
        Light26 = twentysix.GetComponent<loc26>();
        Light27 = twentyseven.GetComponent<loc27>();
        Light28 = twentyeight.GetComponent<loc28>();
        Light29 = twentynine.GetComponent<loc29>();

    }

    uint convertToInt(bool[] ledList){
        uint data = 0;
        for(int i = 0; i < ledList.Length; i++){
            data = data | (uint) (ledList[i] ? 0b1 : 0b0) << i;
        }
        return data;
    }
    

    void Update(){
        bool[] ledList = {Light0.LED0, Light1.LED1, Light2.LED2, Light3.LED3, Light4.LED4, Light5.LED5, Light6.LED6, Light7.LED7, Light8.LED8, Light9.LED9, Light10.LED10, 
        Light11.LED11, Light12.LED12, Light13.LED13, Light14.LED14, Light15.LED15, Light16.LED16, Light17.LED17, Light18.LED18, Light19.LED19, Light20.LED20, 
        Light21.LED21, Light22.LED22, Light23.LED23, Light24.LED24, Light25.LED25, Light26.LED26, Light27.LED27, Light28.LED28, Light29.LED29};
        byte[] data = BitConverter.GetBytes(convertToInt(ledList));
        byte startMarker = 0x3C;
        byte endMarker = 0x3E;
        var z = new byte[data.Length + 2];
        z[0] = startMarker;
        data.CopyTo(z, 1);
        z[data.Length + 1] = endMarker;
        data_stream.Write(z, 0, z.Length);
    }
    // Update is called once per frame
    // void Update()
    // {
    //     // uint data = (true ? 0b1 : 0b0) << 2 | 0b1 << 1  | 0b1;
    //     bool[] ledList = {Light0.LED0, Light1.LED1, Light2.LED2};
    //     byte[] data = BitConverter.GetBytes(convertToInt(ledList));
    //     // Debug.Log();
    //     // Debug.Log(ledList[0].ToString() + ledList[1].ToString() + ledList[2].ToString());
    //     // Debug.Log(data, BIN)
    //     data_stream.Write(data, 0, 4);
    //     data_stream.Write("\n");

    //     // data_stream.Write("hi");
    // }
}
