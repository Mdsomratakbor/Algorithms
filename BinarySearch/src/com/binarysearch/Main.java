package com.binarysearch;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
	int arraySize, searchElement;
        BinarySearch objBinarySearch = new BinarySearch();
        Scanner input = new Scanner(System.in);
        System.out.println("Please enter your array size:");
        arraySize = input.nextInt();
        int[] array = new int[arraySize];
        System.out.println("Please enter your array elements in sort order (ASC or DSC):");
        for(int i=0; i<arraySize; i++){
            array[i] = input.nextInt();
        }
        System.out.println("Please enter your search element:");
        searchElement = input.nextInt();
        int result = objBinarySearch.binarySearch(array, 0, arraySize - 1, searchElement);
        if (result == -1)
            System.out.println("Element not present");
        else
            System.out.println("Element found at index :"
                    + result);

    }
}
