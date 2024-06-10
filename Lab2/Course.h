#pragma once
#include <string>
#include <vector>
#include <map>


class Course {

    std::string name;
    std::vector<std::string> students;
    std::map<std::string, int> marks;

public:

    Course(std::string course_name) : name(course_name) {}

    void join_course(std::string student_name);
    void educate(std::string student_name);
    void give_mark(std::string student_name, int mark);
};