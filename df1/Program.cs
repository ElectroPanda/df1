using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace df1
{
    public class Eval //Объявление основного класса
    {
       public float iCodVal, iRstart, iRend, iCodRange;
       public float fRes;
       public string sCodVal;
       public string sRes;
       

       
        public Eval (float iA, float iB):this(iA,iB,(iB*(-1))) 
        	//Конструктор с двумя аргументами (физическое значение, нижняя граница диапазона)
          //Подставляет верхнюю границу диапазона и передают всё конструктрру с тремя аргументами
        {} //End Eval 2arg constr
        
        
        public Eval (float iA, float iB,float iC):this(iA,iB,iC,65536)
         //Конструктор с тремя аргументами подставляет в качестве разрядности АЦП значение по умолчанию 65536
        {}// End Eval 3arg const
       
       public Eval (float iA, float iB, float iC, float iD) 
       	//основной конструктор присваивает значения полям класса
       {
        this.iCodVal = iA;
        this.iRstart = iB;
        this.iRend = iC;
        this.iCodRange = iD;
       } //end eval 4arg const
       
       

        public void ShowEval () //Метод вывода заголовка: Квантизация, нижняя и верхняя граница диапазона 
       {
           Console.WriteLine("Resolution: " + this.iCodRange +" quantization levels (codes)");
           Console.WriteLine("Lower limit scale: " + this.iRstart);
           Console.WriteLine("Upper limit scale:  " + this.iRend);
           Console.WriteLine("*************************************");
       
          	

       }//End Show
        
        
        public void ShowEvalB() //Метод вывода Заданного значения и результата расчёта
        {
        	Console.Write(this.sCodVal+"");
        	Console.WriteLine(this.sRes+"");
        }
        
        public void CalcEval()
        {
        	
				this.fRes=this.iCodRange/(Math.Abs(this.iRstart)+Math.Abs(this.iRend)); //Рассчёт значения
				this.fRes=this.iCodVal/this.fRes;
				this.fRes=this.fRes+this.iRstart;
				
				if (this.iCodVal>this.iCodRange) //Проверка на превышение диапазона
					
				{
					this.sRes=""; //Подложное значение результата в случае проблемы 
				    this.sCodVal="Invalid value!!! ";
				}
						else
				{this.sRes=this.fRes+" physical  value "; //Формирование строчек итоговых значений
			     this.sCodVal=this.iCodVal+ " binary  value ";}
        	
				

        } //End CalcEval
        
        public void ReCalcEval() //Метод расчёта последующих значений
        {
        	  while ("i"!="y")
           {
            this.sCodVal=Console.ReadLine();
            if (this.sCodVal=="") {break;} //Выход из бесконечного цикла если введённая строчка пуста
            this.iCodVal=Convert.ToSingle(this.sCodVal);
            this.CalcEval();
            this.ShowEvalB();
           }
        	
        	
        } //End ReCalcEval
    } //End Eval


    class Program
    {
        static void Main(string[] args)
        {
                      
            switch(args.Length) //Выбор в зависимости от количества аргументов переданных командной строке
            {
            case 0:
                Console.WriteLine("Not enough parameters!!!	");
               
            break;
            
            case 1:
           		Console.WriteLine("Not enough parameters!!! ");
          
            break;
           
            case 2: //Два аргумента
            Eval obE = new Eval(Convert.ToSingle(args[0]), Convert.ToSingle(args[1])); 
            //Аргументы превращаются в числа и передаются соответсвующему конструтору
            
            obE.ShowEval();
            obE.CalcEval();
            obE.ShowEvalB();
            obE.ReCalcEval();
            
            
            
            break;
            
            case 3:
            Eval obA = new Eval(Convert.ToSingle(args[0]), Convert.ToSingle(args[1]),Convert.ToSingle(args[2]));
            
            obA.ShowEval();
            obA.CalcEval();
            obA.ShowEvalB();
            obA.ReCalcEval();
            
            break;
            
            case 4:
            Eval obB = new Eval(Convert.ToSingle(args[0]), Convert.ToSingle(args[1]),Convert.ToSingle(args[2]),Convert.ToSingle(args[3]));
            
            obB.ShowEval();
            obB.CalcEval();
            obB.ShowEvalB();
            obB.ReCalcEval();
            
            break;
            
           default:
            Console.WriteLine("Too many parameters!");
            break;
            	
            } //end swith

          
           Console.ReadLine();

        
        } //End Main
    } //End Program
} //End Namespace
