// Package weather provides a way to forecast current weather conditions.
package weather

// CurrentCondition represents the weather condition of CurrentLocation.
var CurrentCondition string
// CurrentLocation represents the location to forecast.
var CurrentLocation string

// Forecast takes a name of a city of Goblinocus and a weather condition and 
// returns the current weather condition of the CurrentLocation.
func Forecast(city, condition string) string {
	CurrentLocation, CurrentCondition = city, condition
	return CurrentLocation + " - current weather condition: " + CurrentCondition
}
