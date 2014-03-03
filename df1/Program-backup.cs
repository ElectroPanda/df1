/*
 * Created by SharpDevelop.
 * User: Administrаtor
 * Date: 17.01.2014
 * Time: 17:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace df1
{
	class dataform  {
		int ibitval; 
		int istart; 
		int iend;
		int ires;
		int idiap;
		
		public dataform(int ibit){
			
			this.iend=10;
			this.istart=-10;
			this.ibitval=ibit;
			
		}
		
		
		public int Eval
		{
		   get{
				if (this.istart<0 && this.iend>0) then 
				{
					this.istart=-1*(this.istart);
					this.idiap=this.istart+this.iend;
					
				}
				
		    
			return this.ires;
			
			} //end Get
			} //end Eval
	}  //end dataform
	
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine(args.Length);
			dataform oap =new dataform(23856);
			Console.WriteLine(oap.Eval);
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadLine();
			
		}
	}
}