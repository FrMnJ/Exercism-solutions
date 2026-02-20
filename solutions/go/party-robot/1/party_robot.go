package partyrobot

import "fmt"

// Welcome returns a welcome party message
func Welcome(name string) string {
	return fmt.Sprintf("Welcome to my party, %s!", name)
}

// HappyBirthday returns a birthday message
func HappyBirthday(name string, age int) string {
	return fmt.Sprintf("Happy birthday %s! You are now %d years old!", name, age)
}

// AssignTable returns directions to the table at a party.
func AssignTable(name string, tableNumber int, seatmateName, direction string, distance float64) string {
	return fmt.Sprintf("%s\nYou have been assigned to table %03d. Your table is %s, exactly %.1f meters from here.\nYou will be sitting next to %s.", Welcome(name), tableNumber, direction, distance, seatmateName)
}

