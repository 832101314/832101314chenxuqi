using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public double memory1 = 0; 
    public double memory = 0;
    public double memory2 = 0;
    public int times = 0;
    public int equla = 0;
    public int state = 0;
    public double result = 0;
    public bool plus=false;
    public bool minus = false;
    public bool divi = false;
    public bool multi = false;
    public void num0()
    {
        Initial();
        textMeshPro.text += "0";

        
}
    public void num1()
    {
        Initial();
        textMeshPro.text += "1";

    }
    public void num2()
    {
        Initial();
        textMeshPro.text += "2";
        
    }
    public void num3()
    {
        Initial();
        textMeshPro.text += "3";
        
    }
    public void num4()
    {
        Initial();
        textMeshPro.text += "4";

        
    }
    public void num5()
    {
        Initial();
        textMeshPro.text += "5";

     
    }
    public void num6()
    {
        Initial();
        textMeshPro.text += "6";

    }
    public void num7()
    {
        Initial();
        textMeshPro.text += "7";

    }


    public void num8()
    {
        Initial();
        textMeshPro.text += "8";

    }
    public void num9()
    {
        Initial();
        textMeshPro.text += "9";

    }
    public void Poin()
    {
        textMeshPro.text += ".";
    }



    public void Plus()
    {
        if (times > 0)
        {
            num14();
            memory = result;
            ClearShow();
            
        }
        else
        {
            memory = float.Parse(textMeshPro.text);
            memory2 = memory;
            ClearShow();
            times++;
        }
        plus = true;
        state = 2;
    }
    public void Initial()
    {
        if (textMeshPro.text == "0" )
        {
            ClearShow();
        }
    }
    public void ClearShow()
    {
        textMeshPro.text = null;
    }
    public void Minus()
    {
        if (times > 0)
        {
            num14();
            memory = result;
            ClearShow();
            
        }
        else
        {
            memory = float.Parse(textMeshPro.text);
            memory2 = memory;
            ClearShow();
            times++;
        }
        minus = true;
        state = 3;
}
    public void Multi()
    {
        if (times > 0)
        {
            num14();
            memory = result;
            ClearShow();
            
        }
        else
        {
            memory = float.Parse(textMeshPro.text);
            ClearShow();
            times++;
        }
        multi = true;
    }
    public void Divi()
    {
        if (times > 0)
        {
            num14();
            memory = result;
            ClearShow();
            
        }
        else
        {
            memory = float.Parse(textMeshPro.text);
            ClearShow();
            times++;
        }
        divi = true;
        
    }


    public void num14()
    {
        if (plus)
        {
            memory1 = float.Parse(textMeshPro.text);
            result = memory + memory1;
            plus = false;
        }else if (minus)
        {
            memory1 = float.Parse(textMeshPro.text);
            result = memory - memory1;
            minus = false;
        }else if (multi)
        {
            memory1 = float.Parse(textMeshPro.text);
            if (state == 2)
            {
                memory = memory - memory2;
                result = memory * memory1 + memory2;
                state = 0;
                memory2 = 0;
            }
            else if (state == 3)
            {
                memory = memory + memory2;
                result = memory * memory1 - memory2;
                memory2 = 0;
            }
            else
            {
                result = memory * memory1;
            }
        }
        else if (divi)
        {
            memory1 = float.Parse(textMeshPro.text);
            if (state == 2)
            {
                memory = memory - memory2;
                result = memory / memory1 + memory2;
                memory2 = 0;
            }
            else if (state == 3)
            {
                memory = memory + memory2;
                result = memory / memory1 - memory2;
                memory2 = 0;
            }
            else
            {
                result = memory / memory1;
            }
            divi = false;
        }
                   
       
        ClearShow();
        textMeshPro.text =result.ToString();
    }

    public void num15()
    {
        if (plus)
        {
            memory1 = float.Parse(textMeshPro.text);
            result = memory + memory1;

            plus = false;
        }
        else if (minus)
        {
            memory1 = float.Parse(textMeshPro.text);
            result = memory - memory1;
            minus = false;
        }
        else if (multi)
        {
            memory1 = float.Parse(textMeshPro.text);
            if(state == 2)
            {
                memory = memory - memory2;
                result = memory * memory1 + memory2;
                memory2 = 0;
            }else if (state == 3)
            {
                memory = memory + memory2;
                result = memory * memory1 - memory2;
                memory2 = 0;
            }
            else {
                result = memory * memory1 ;
            }
            
            multi = false;
        }
        else if (divi)
        {
            memory1 = float.Parse(textMeshPro.text);
            if (state == 2)
            {
                memory = memory - memory2;
                result = memory / memory1 + memory2;
                memory2 = 0;
            }
            else if (state == 3)
            {
                memory = memory + memory2;
                result = memory / memory1 - memory2;
                memory2 = 0;
            }
            else
            {
                result = memory / memory1;
            }
            divi = false;
        }
        ClearShow();
        textMeshPro.text = result.ToString();
        memory = 0;
        memory1 = 0;
        result = 0;
        times = 0;
        state = 0;
    }
    public void clear()
    {
        textMeshPro.text = "0";
        
    }

    public string delete;
    public int i = 0;
    public void dele()
    {
        textMeshPro.text = textMeshPro.text.Substring(0, textMeshPro.text.Length - 1);       

    }
    
}
