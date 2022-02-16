package com.binarysearch;

public class BinarySearch {
    public int binarySearch(int[] array, int startIndex, int endIndex, int findValue){
      if(endIndex>=startIndex){
          /*Find mid element*/
          int midElement = startIndex+(endIndex-startIndex)/2;
          /* If the element is present at the*/
          /* middle itself*/
          if(array[midElement]==findValue)
              return midElement;

          /* If element is smaller than mid, then*/
          /* it can only be present in left subarray*/
          if(array[midElement]>findValue)
              return  binarySearch(array, startIndex, midElement-1, findValue);
          /* Else the element can only be present*/
          /* in right subarray*/
          return binarySearch(array, midElement + 1, endIndex, findValue);
      }
    return  -1;
    }

}
