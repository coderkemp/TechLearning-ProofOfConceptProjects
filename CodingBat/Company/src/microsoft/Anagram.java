package microsoft;
import java.util.*;

public class Anagram {

	public Boolean anagramTest(String str1, String str2){
		Boolean test = false;
		int countS=0,countT=0;
		TreeSet<String> t1=new TreeSet<String>();
        TreeSet<String> t2=new TreeSet<String>();
        
		int sizeStr1=str1.length();
		int sizeStr2=str2.length();
        for(int i=0;i<str1.length();i++){
        	t1.add(str1.substring(i,i+1));
        }
        System.out.println(t1.size());
        for(int i=0;i<str2.length();i++){
        	t2.add(str2.substring(i,i+1));
        }
        System.out.println(t2.size());
     
		if(sizeStr1==sizeStr2){
		if(t1.size()==t2.size()){
		for(int i=0;i<str1.length();i++){
			for(int j=0;j<str2.length();j++){
				if(str1.substring(i,i+1).equals(str2.substring(j,j+1))){
					countS++;
				}
			}
		}
		for(int i=0;i<str2.length();i++){
			for(int j=0;j<str1.length();j++){
				if(str2.substring(i,i+1).equals(str1.substring(j,j+1))){
					countT++;
				}
			}
		}
		}
		}
		System.out.println(countS);
		System.out.println(countT);
	    if((countS==countT) && (countS!=0 && countT!=0) && ((t1.size()==t2.size())))test=true;
		return test;
	}
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
        Anagram ag = new Anagram();
        System.out.println(ag.anagramTest("aacc", "ccac"));
        
	}

}
//Anagram Examples
//Listen,Silent
//Triangle,Integral