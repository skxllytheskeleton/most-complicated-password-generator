// My most COMPLICATED password generator
// Written by skxllytheskeleton - https://github.com/skxllytheskeleton/

import java.util.*;

public class Main {
  // Settings
  public static int length = 20;
  public static boolean includecapitals = true;
  public static boolean includenumbers = true;
  public static boolean includesymbols = true;
  public static boolean includeemojis = true;
  public static boolean includenonlatin = true;
  public static boolean includestupidity = true;
  public static boolean includeunicode = true;
  public static boolean includewhitespace = true;
  // Set-up
  public static String allchars = "";
  public static char randomchar() {
    int index = (int)(Math.random() * allchars.length());
    return allchars.charAt(index);
  }
  // Pools
  public static String alphabet = "abcdefghijklmnopqrstuvwxyz";
  public static String numbers = "0123456789";
  public static String symbols = "`~!@#$%^&*()-_=+{}[]|;:'<>,./?";
  public static String emojis = "💿🍁🧂😠😭🪑😛💔🥀🕊️✌️🙏";
  public static String nonlatin = "ΑαΔδΗηθΘεΕβΒΓγΖζΙιπΠνΝκΚΛλΞξΡρςΣοΟμΜΤτΧχσϠϡψΨυΥΦφΩωϜϝέΈ";
  public static String stupidity = "–—€£¥©²°•é→←—№™®℗©℃−§¦⌈⌉⌊⌋‖⟬⟭⟧⟦⟫⟪‰⁂✓✕⁐¿�¡";
  public static String unicode = "☂☎☘☢☣☪☮☯☻☀☬♻";
  public static String whitespace = "   ";
  public static void main(String[] args) {
    // Set-up²
    allchars += alphabet;
    // Apply settings
    if (includecapitals) {
      allchars += alphabet.toUpperCase();
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
    String password = "";
    for (int i = 0; i < length; i++) {
      password += randomchar();
    }
    // Output
    System.out.println(password);
  }
}
