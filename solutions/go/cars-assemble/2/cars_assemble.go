package cars

// CalculateWorkingCarsPerHour calculates how many working cars are
// produced by the assembly line every hour.
func CalculateWorkingCarsPerHour(productionRate int, successRate float64) float64 {
    return float64(productionRate) * (successRate / 100)
}

// CalculateWorkingCarsPerMinute calculates how many working cars are
// produced by the assembly line every minute.
func CalculateWorkingCarsPerMinute(productionRate int, successRate float64) int {
    return int(CalculateWorkingCarsPerHour(productionRate,successRate) / 60.0)
}

const costTenCars = 95000
const costOneCar  = 10000

// CalculateCost works out the cost of producing the given number of cars.
func CalculateCost(carsCount int) uint {
    numGroupsOfTen := carsCount / 10
    numIndividuals := carsCount % 10
    return uint(costTenCars)*uint(numGroupsOfTen) + 
    uint(costOneCar) * uint(numIndividuals)
}
