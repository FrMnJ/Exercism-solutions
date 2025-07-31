#include <array>
#include <string>
#include <vector>
#include <cmath>

// Round down all provided student scores.
std::vector<int> round_down_scores(std::vector<double> student_scores) {
    // TODO: Implement round_down_scores
    std::vector <int> rounded_scores;
    for(int i=0;i<student_scores.size();++i){
        rounded_scores.emplace_back(static_cast<int>(student_scores[i]));
    }
    return rounded_scores;
}

// Count the number of failing students out of the group provided.
int count_failed_students(std::vector<int> student_scores) {
    // TODO: Implement count_failed_students
    int  counter= 0;
    for(int i = 0; i<student_scores.size() ; ++i){
        if(student_scores[i]<=40) ++counter;
    }
    return counter;
}

// Create a list of grade thresholds based on the provided highest grade.
std::array<int, 4> letter_grades(int highest_score) {
    // TODO: Implement letter_grades
    int diff = (highest_score - 40)/ 4;
    std::array<int, 4> letter_grades;
    int current_grade = 41;
    for(int i=0; i<4; ++i){
        letter_grades[i] = current_grade;
        current_grade += diff;
    }
    return letter_grades;
}

// Organize the student's rank, name, and grade information in ascending order.
std::vector<std::string> student_ranking(
    std::vector<int> student_scores, std::vector<std::string> student_names) {
    // TODO: Implement student_ranking
    std::vector<std::string> ranking;
    for(int i=0;i<student_scores.size();++i){
        ranking.emplace_back(std::to_string(i+1)+". "+student_names[i]+": "+std::to_string(student_scores[i]));
    }
    return ranking;
}

// Create a string that contains the name of the first student to make a perfect
// score on the exam.
std::string perfect_score(std::vector<int> student_scores,
                          std::vector<std::string> student_names) {
    // TODO: Implement perfect_score
    for(int i=0;i<student_scores.size();++i){
        if(student_scores[i]==100){
           return student_names[i];
        } 
    }
    return "";
}
