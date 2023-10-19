using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQ
{
    /*
     * LINQ 의 개념
     * from
     * where
     * orderby
     * select
     * groupby
     * join
     * 
     * LINQ (Language INtegrated Query)
     *  C#언어에 통합된 데이터 질의 기능
     *  프로그래밍에서 많은 부분을 차지하는 데이터 작업의 효율을 크게 향상
     *  데이터 질의란 데이터 집합에서 원하는 데이터를 찾는 작업
     *  데이터 질의 기본 요소
     *      From : 어떤 데이터 집합에서
     *      Where : 어떤 조건으로
     *      Select : 어떤 항목을
     * 
     *  class Profile
     *  {
     *      public string Name {get; set;}
     *      public int Height {get; set;}
     *  }
     *  
     *  Profile[] arrProfile = {
     *      new Profile() { Name = "정우성", Height = 186},
     *      new Profile() { Name = "김태희", Height = 158},
     *      new Profile() { Name = "고현정", Height = 172},
     *      new Profile() { Name = "이문세", Height = 178},
     *      new Profile() { Name = "하동훈", Height = 171},
     *  };
     *  
     * 기존
     *  List<Profile> profiles = new List<Profile>();
     *  foreach (Profile profile in arrProfile)
     *  {
     *      if (porfile.Height < 175)
     *      {
     *          profiles.Add(profile);
     *      }
     *  }
     *      profiles.Sort ((profile1, profile2) => 
     *      {
     *          return profile1.Height - profile2.Height;
     *      });
     *      
     *      foreach (var profile in profiles)
     *      {
     *          Console.WriteLine("{0}, {1}", profile.Name, profile.Height);
     *      }
     *  }
     * 
     * LINQ
     *  var profiles = from profile in arrProfile
     *                 where profile.Height < 175
     *                 orderby profile.Height
     *                 select profile;
     *                 
     *  foreach (var profile in profiles)
     *  {
     *      Console.WrtieLine("{0}, {1}", profile.Name, profile.Height);
     *  }
     *  
     * from 절
     *  from <범위변수> in <데이터원본> 의 형식
     *  ex:
     *      int[] numbers = {1, 2, 3, 4, 5,6, 7, 8, 9, 10};
     *      var result = from n in numbers
     *                   where n % 2 == 0
     *                   orederby n
     *                   select n;
     *      foreach (int n in result)
     *      {
     *          Console.WriteLine("짝수 : {0}", n);
     *      }
     * where 절
     *  찾고자 하는 데이터를 필터
     *  범위 변수가 충족해야 하는 조건을 매개 변수로 입력
     *  ex:
     *      Profile[] arrProfile = 
     *      {
     *          new Profile() { Name = "정우성", Height = 186},
     *          new Profile() { Name = "김태희", Height = 158},
     *          new Profile() { Name = "고현정", Height = 172},
     *          new Profile() { Name = "이문세", Height = 178},
     *          new Profile() { Name = "하동훈", Height = 171},
     *      };
     *      
     *     var profiles = from profile in arrProfile
     *                    where profile.Height < 175
     *                    select profile;
     * 
     * orderby 절
     *  필터링된 데이터를 정렬
     *  ascending(오름차순), descending(내림차순)선택가능
     *      아무것도 선택하지 않으면 ascending 기본 적용
     *      ex: 1.
     *          var profiles = from profile in arrProfile
     *                         where profile.Height < 175
     *                         orderby profile.Height
     *                         select profile
     *          2.
     *          var profiles = from in arrProfile
     *                         where profile.Height < 175
     *                         orderby profile.Height ascending
     *                         select profile;
     *          1과 2는 같은 출력을 나타낸다
     *          
     * select 절
     *  최종 결과를 추출하는 쿼리식의 마침표 같은 존재
     *  LINQ질의 결과인 IEnumerable<T> 객체의 매개변수 T는 select 문에 의해 결정
     *      ex:
     *          var profiles = from profile in arrProfile             profiles의 형식은 IEnumerable<Profile>
     *                         where profile.Height < 175
     *                         orderby profile.Height
     *                         select profile;
     *                         
     *          var profiles = from profole in arrProfile             profiles의 형식은 IEnumerable<string>
     *                         where profile.Height < 175
     *                         orderby profile.Height
     *                         select profile.Name;
     *          
     *          var profiles = from profile in arrProfile             profiles의 형식은 IEnumerable<무명형식>
     *                         where profile.Height < 175
     *                         orderby profile.Height 
     *                         select new { Name = profile.Name, InchHeight = profile.Height * 0.494 }'
     * 
     * group by 절
     *  특정 기준으로 데이터를 분류
     *      ex:
     *      Profile[] arrProfile = 
     *      {
     *          new Profile() { Name = "정우성", Height = 186},
     *          new Profile() { Name = "김태희", Height = 158},
     *          new Profile() { Name = "고현정", Height = 172},
     *          new Profile() { Name = "이문세", Height = 178},
     *          new Profile() { Name = "하동훈", Height = 171},
     *      };
     *      
     *      var listProfile = from profile in arrProfile
     *                        group profile by profile.Height < 175 into g
     *                        select new { GroupKey = g.key, Profiles = g };
     *                        
     * join 절
     *  두 데이터 원본을 연결하는 연산
     *  각 데이터 우너본에서 특정 필드가 일치하는 데이터끼리 연결
     *  내부 조인 : 일종의 교집합; 두 데이터 원본 사이에서 일치하는 데이터만 연결하여 반환
     *  외부 조인 : 한쪽 데이터 원본을 기준으로 삼은 상태에서 다른 데이터 원본과 결합하여 반환
     *      내부조인 ex:
     *          var listProfile = from profile in arrProfile
     *                            join product in arrProduct
     *                            on profile.name equals product.Start
     *                            select new { Name = profile.Name,
     *                                         Work = profile.Title,
     *                                         Height = profile.Height
     *                                       };
     *  외부 조인
     *      join 절을 이용해서 조인을 수행 한 후 그 결과를 임시 컬렉션에 저장
     *      DefaultIfEmpty 연산을 통해 임시 컬렉션의 비어 있는 조인 결과에 빈 값 삽입
     *      DefailtIfEmpty 연산을 거친 임시 컬렉션에서 다시 from 절을 통해 범위 변수 추출
     *      범위 변수와 기준 데이터 원본에서 뽑아낸 범위 변수를 이용해서 최종 결과 추출
     *          외부조인 ex:
     *              var listProfile = from profile in arrProfile
     *                                join product in arrProduct
     *                                on profile.Name equals product.Start into ps
     *                                from sub_product in ps.DefaultIfEmpty(new Product () { Title = "그런거 없음"})
     *                                select new { Name = profile.Name
     *                                             Work = sub_product.Title,
     *                                             Height = profile.Height
     *                                           };
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Profile[] profiles = 
            { 
                new Profile() { Name = "정우성", Height = 186 },
                new Profile() { Name = "김태희", Height = 170 },
                new Profile() { Name = "고윤정", Height = 158 },
                new Profile() { Name = "한효주", Height = 172 },
                new Profile() { Name = "이문세", Height = 170 },
                new Profile() { Name = "강동원", Height = 192 }
            };


            var profilesData = from profile in profiles
                               where profile.Height < 175
                               orderby profile.Height
                               select profile;

            foreach ( var profile in profilesData )
            {
                Console.WriteLine($"{profile.Name}, {profile.Height}");
            }

            Console.ReadKey();
        }
    }

    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
}
