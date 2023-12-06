// null : 아무 것도 없음을 의미하는 리터럴, 개체가 아무것도 참조하지 않는것
// int i = 0;  값형(value type)
// string s = null; 참조형(Reference Type)
// s = "안녕하세요.";
// string empty = ""; 빈값은 null값
// Nullable<T> 구조체를 사용하여 널 가능 형식 변수 만들기
// Nullable<bool> bln = null;
// bln.HasValue 결과는 false

// ?. 연산자 : 컬렉션이 null이면 null, 그렇지 않으면 뒤에 오는 속성 값 반환
// ex : List<string> list = null;
//      int? numberOfList;
// [1]리스트가 null이면 null반환 값이 있으면 그 string값을 반환


