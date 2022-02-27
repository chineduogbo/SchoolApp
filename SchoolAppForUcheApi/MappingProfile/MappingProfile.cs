using SchoolAppForUcheApi.Model;
using SchoolAppForUcheApi.Model.DTO;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAppForUcheApi.MappingProfile
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
           
            CreateMap<Announcements, AnnouncementsDTO>().ForMember(x => x.Username, o => o.MapFrom(a => a.User.Username))
            .ForMember(x => x.Firstname, o => o.MapFrom(a => a.User.Firstname))
            .ForMember(x => x.Lastname, o => o.MapFrom(a => a.User.Lastname))
            .ForMember(x => x.Othername, o => o.MapFrom(a => a.User.Othername))
             .ForMember(x => x.RoleName, o => o.MapFrom(a => a.User.Role.Name));
            CreateMap<Attendance, AttendanceDto>().ForMember(x => x.ClassName, o => o.MapFrom(a => a.SubjectAssignment.Classsubgroup.Class.Name))
            .ForMember(x => x.ClasssubgroupName, o => o.MapFrom(a => a.SubjectAssignment.Classsubgroup.Name))
            .ForMember(x => x.SubjectName, o => o.MapFrom(a => a.SubjectAssignment.Subjects.Name))
            .ForMember(x => x.Username, o => o.MapFrom(a => a.User.Username))
            .ForMember(x => x.StudentFirstname, o => o.MapFrom(a => a.Student.Firstname))
            .ForMember(x => x.StudentLastname, o => o.MapFrom(a => a.Student.Lastname))
            .ForMember(x => x.StudentOthername, o => o.MapFrom(a => a.Student.Othername)); ;
            CreateMap<Classsubgroup, ClasssubgroupDto>().ForMember(x => x.ClassName, o => o.MapFrom(a => a.Class.Name));
            CreateMap<Activeterm, ActivetermDto>().ForMember(x => x.TermName, o => o.MapFrom(a => a.Term.Name))
            .ForMember(x => x.SessionTermName, o => o.MapFrom(a => a.Session.Name));
            CreateMap<Result, ResultDto>().ForMember(x => x.ClassName, o => o.MapFrom(a => a.SubjectAssignment.Classsubgroup.Class.Name))
            .ForMember(x => x.ClasssubgroupName, o => o.MapFrom(a => a.SubjectAssignment.Classsubgroup.Name))
            .ForMember(x => x.SubjectName, o => o.MapFrom(a => a.SubjectAssignment.Subjects.Name))
            .ForMember(x => x.Username, o => o.MapFrom(a => a.User.Username))
            .ForMember(x => x.StudentFirstname, o => o.MapFrom(a => a.Student.Firstname))
            .ForMember(x => x.StudentLastname, o => o.MapFrom(a => a.Student.Lastname))
            .ForMember(x => x.StudentOthername, o => o.MapFrom(a => a.Student.Othername));
            CreateMap<Studentclass, StudentclassDto>().ForMember(x => x.ClassName, o => o.MapFrom(a => a.Classsubgroup.Class.Name))
            .ForMember(x => x.ClasssubgroupName, o => o.MapFrom(a => a.Classsubgroup.Name))
            .ForMember(x => x.TermName, o => o.MapFrom(a => a.Activeterm.Term.Name))
            .ForMember(x => x.SessionName, o => o.MapFrom(a => a.Activeterm.Session.Name))
            .ForMember(x => x.StudentFirstname, o => o.MapFrom(a => a.Student.Firstname))
            .ForMember(x => x.StudentLastname, o => o.MapFrom(a => a.Student.Lastname))
            .ForMember(x => x.StudentOthername, o => o.MapFrom(a => a.Student.Othername));
            CreateMap<Teacherclass, TeacherclassDto>().ForMember(x => x.ClassName, o => o.MapFrom(a => a.Classsubgroup.Class.Name))
            .ForMember(x => x.ClasssubgroupName, o => o.MapFrom(a => a.Classsubgroup.Name))
            .ForMember(x => x.TermName, o => o.MapFrom(a => a.Activeterm.Term.Name))
            .ForMember(x => x.SessionName, o => o.MapFrom(a => a.Activeterm.Session.Name))
             .ForMember(x => x.Username, o => o.MapFrom(a => a.User.Username));
            CreateMap<Test, TestDto>().ForMember(x=>x.ClassName ,o=> o.MapFrom(a=>a.SubjectAssignment.Classsubgroup.Class.Name))
            .ForMember(x => x.ClasssubgroupName, o => o.MapFrom(a => a.SubjectAssignment.Classsubgroup.Name))
            .ForMember(x => x.SubjectName, o => o.MapFrom(a => a.SubjectAssignment.Subjects.Name))
            .ForMember(x => x.SubjectId, o => o.MapFrom(a => a.SubjectAssignment.SubjectId));
            CreateMap<User, UserDto>().ForMember(x => x.RoleName, o => o.MapFrom(a => a.Role.Name));
            CreateMap<CreateUserDto, User>();
            CreateMap<UserDto, User>();
            CreateMap<CreateActivetermDto, Activeterm>();
            CreateMap<CreateAnnouncementsDTO, Announcements>();
            CreateMap<CreateAttendanceDto, Attendance>();
            CreateMap<CreateClasssubgroupDTO, Classsubgroup>();
            CreateMap<CreateResultDto, Result>();
            CreateMap<CreateStudentclassDto, Studentclass>();
            CreateMap<CreateTeacherclassDto, Teacherclass>();
            CreateMap<CreateTestDto, Test>();
            CreateMap<ActivetermDto, Activeterm>();
            CreateMap<AnnouncementsDTO, Announcements>();
            CreateMap<AttendanceDto, Attendance>();
            CreateMap<ClasssubgroupDto, Classsubgroup>();
            CreateMap<ResultDto, Result>();
            CreateMap<StudentclassDto, Studentclass>();
            CreateMap<TeacherclassDto, Teacherclass>();
            CreateMap<TestDto, Test>();

        }
    }
}
