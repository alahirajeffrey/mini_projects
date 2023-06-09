package main

import (
	"fmt"
	"math"
)

func main() {

	// var populationSize int 
	var marginError, sampleSize, populationSize float32
	// var response string

    fmt.Println("Taro Yamane Calculator.")

	// get the population size
	fmt.Println("Please enter the population size : ")
	fmt.Scan(&populationSize)

	fmt.Println("Please enter the margin error : ")
	fmt.Scan(&marginError)

	sampleSize = populationSize/ (1 + populationSize* float32(math.Pow(float64(marginError), 2)))
	fmt.Println(sampleSize)


}