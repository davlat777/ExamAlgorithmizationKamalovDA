import random
import datetime

class Students:
    def __init__(self,name,group,admission_year):
        self.name = name
        self.group = group
        self.admission_year = admission_year

class Group:
    def __init__(self,name):
        self.name = name
        self.students = []
    def add_student(self,name,admission_year):
        self.students.append(Students(name,self.name,admission_year))
    def generate_attedance_and_grades(self, days=10):
        for student in self.students:
            print(f"Студент: {student.name}")
            present_date = datetime.datetime.now()
            for i in range(days):
                day = present_date + datetime.timedelta(days=i)
                attendance = random.choice(["П","О"])
                grade = random.randint(1,5) if attendance == "П" else "-"
                print(f"Дата: {day.strftime('%d.%m.%Y')}, Посещаемость: {attendance}, Оценка: {grade}")

group1 = Group("Group1")

group1.add_student("Иван Иван Иван", "2018")
group1.add_student("А А А", "2018")
group1.add_student("Дима Дима Дима", "2019")

group1.generate_attedance_and_grades()
