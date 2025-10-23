// My most COMPLICATED password generator
// Written by skxllytheskeleton - https://github.com/skxllytheskeleton/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ComplicatedPassGen {
	public class Program {
	  // Settings
	  public static int length = 20;
	  public static bool includecapitals = true;
	  public static bool includenumbers = true;
	  public static bool includesymbols = true;
	  public static bool includeemojis = true;
	  public static bool includenonlatin = true;
	  public static bool includestupidity = true;
	  public static bool includeunicode = true;
	  public static bool includewhitespace = true;
	  // Set-up
	  public static Random rng = new Random();
	  public static string allchars = "";
	  public static char randomchar() {
	    int index = rng.Next(allchars.Length);
	    return allchars[index];
	  }
	  // Pools
	  public static string alphabet = "abcdefghijklmnopqrstuvwxyz";
	  public static string numbers = "0123456789";
	  public static string symbols = "`~!@#$%^&*()-_=+{}[]|;:'<>,./?";
	  public static string emojis = "🍁🧂😠😭🪑😛💔🥀🕊️✌️🙏";
	  public static string nonlatin = "ΑαΔδΗηθΘεΕβΒΓγΖζΙιπΠνΝκΚΛλΞξΡρςΣοΟμΜΤτΧχσϠϡψΨυΥΦφΩωϜϝέΈ";
	  public static string stupidity = "–—€£¥©²°•é→←—№™®℗©℃−§¦⌈⌉⌊⌋‖⟬⟭⟧⟦⟫⟪‰⁂✓✕⁐¿�¡";
	  public static string unicode = "☂☎☘☢☣☪☮☯☻☀☬♻";
	  public static string whitespace = "   ";
	  // Main script
		public static void Main(string[] args) {
		  // Set-up²
		  allchars += alphabet;
		  // Apply settings
		  if (includecapitals) {
		    allchars += alphabet.ToUpper();
		  }
		  if (includenumbers) {
		    allchars += numbers;
		  }
		  if (includesymbols) {
		    allchars += symbols;
		  }
		  if (includeemojis) {
		    allchars += emojis;
		  }
		  if (includenonlatin) {
		    allchars += nonlatin;
		  }
		  if (includestupidity) {
		    allchars += stupidity;
		  }
		  if (includeunicode) {
		    allchars += unicode;
		  }
		  if (includewhitespace) {
		    allchars += whitespace;
		  }
		  // Create password
		  string password = "";
			for (int i = 0; i < length; i++) {
			  password += randomchar();
			}
			// Output
			Console.WriteLine(password);
		}
	}
}