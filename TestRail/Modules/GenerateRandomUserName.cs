/*
 * Created by Ranorex
 * User: sjpkn
 * Date: 02/12/2017
 * Time: 14:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace TestRail.Modules
{
    /// <summary>
    /// Description of GenerateRandomUserName.
    /// </summary>
    [TestModule("C27E5037-9162-4F78-9457-7473336309E3", ModuleType.UserCode, 1)]
    public class GenerateRandomUserName : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public GenerateRandomUserName()
        {
            // Do not delete - a parameterless constructor is required!
        }
        
        
        string _RandomUserNameOuput = "";
        [TestVariable("bb165195-f52e-42e6-8dd5-05010095848f")]
        public string RandomUserNameOuput
        {
        	get { return _RandomUserNameOuput; }
        	set { _RandomUserNameOuput = value; }
        }
        
        
        string _RandomEmailAddressOutput = "";
        [TestVariable("d311cfe6-7f06-44c5-af57-92d253a8caed")]
        public string RandomEmailAddressOutput
        {
        	get { return _RandomEmailAddressOutput; }
        	set { _RandomEmailAddressOutput = value; }
        }
        
        
	    public static string getRandomString(int minLength, int maxLength, bool initialCaps) {
		    
		    Random r = new Random();
			int length = r.Next(minLength, maxLength);
		    char[] characters = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
		    StringBuilder sb = new StringBuilder();
		    
		    for (int i = 0; i < length; i++) {
		        sb.Append(characters[r.Next(26)]);
		    }
		           
		    if (initialCaps) return sb.ToString().Substring(0,1).ToUpper() + sb.ToString().Substring(1);
		    return sb.ToString();
		}      
        

        public static string getRandomName()
        {
        	string randomName = getRandomString(5,10,true) + " " + getRandomString(6,12,true);
        	return randomName;
        }
        
        public static string getRandomEmail(string name)
        {
        	string emailPrefix = name.Replace(" ", String.Empty);
        	string emailAddress = emailPrefix + "@" + "testemail.com";
        	return emailAddress;
        }
        

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
        	string randomName = getRandomName();
        	RandomUserNameOuput = randomName;
        	RandomEmailAddressOutput = getRandomEmail(randomName);
        }
    }
}
