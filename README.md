# CG_TeamProject
  
## 2022년 2학기 심화전공 컴퓨터그래픽스 팀 프로젝트  
  
팀명 : 그래픽  
팀원 : **이효리**, 김영은, 윤수윤  
강의자료 : <a href="https://o365karts-my.sharepoint.com/:o:/g/personal/sva768_office_karts_ac_kr/En_H1gIFwwxNjH9ESQYVR8oBcq0rV4gtflej1NnExKSKXw?e=eDpeQJ" target="_blank" title="2022년 2학기 심화전공 컴퓨터그래픽스 강의자료">Share_ComputerGraphics_LD_2022Q3</a>
  
---
  
## 협업 방식
- 명명 규칙 : 파스칼케이스(예: `PascalCase`)
- 역할 분담 : 씬 단위 분담, 필요한 요소 각자 만들기.
    - fps캐릭터와 미니맵은 프리펩으로 공유, UI는 각자
    - 천상(`Assets/Upperworld/`) : 무릉도원, 이효리
    - 지상(`Assets/Middleworld/`) : 현대, 윤수윤
    - 지하(`Assets/Lowerworld/`) : 저승, 김영은
    - FPSCharacter(1인칭) 프리펩 : 김영은
    - 단축키와 콜라이더 충돌을 포함한 씬 이동 스크립트 : 윤수윤
    - 인덱스 씬 : 이효리
- 커밋 메시지 : 어떤 부분을 변경하였는지 또는 무엇을 하였는지 간략하게 적는 것을 권장.

---

## 공통 사항
- 런타임 중 씬 이동은 `Ctrl+방향키` 또는 `Ctrl+숫자키`이며 각 씬의 상하개념에 따라 단축키 부여 : 하나의 스크립트를 공용으로 쓰기로 했기 때문에 모든 씬에서 단축키 구성은 동일하다.

---

## 주의 사항
유니티 에디터를 사용하지 않고 프로젝트 내의 파일을 삭제할 경우, 해당 파일과 같은 이름을 갖는 `.meta` 파일도 함께 삭제해야 추후 에디터를 실행할 때 오류가 발생하지 않는다. 새 파일을 추가하는 것은 괜찮다.

---

## 발표
### 중간 점검 발표
발표자 : 이효리  
PPT 제작 : 윤수윤(씬 구상, 협업 환경), 김영은(팀원별 주요 과업, PPT 정리 및 마무리) / 구글 문서로 공동 작업  
발표 자료 : [컴퓨터그래픽스_진행상황발표_그래픽.pptx](https://docs.google.com/presentation/d/14ZV-yekGSODbI8HuWonp2Sn4wms2TZQP/edit?usp=sharing&ouid=113309621803756900421&rtpof=true&sd=true)  
  
### 기말 발표
논의 사항 : [MEMO.md](MEMO.md) 참고  
자세한 구현 사항 : [Requirements.md](Requirements.md) 참고  
발표자 : 이효리  
PPT 제작 : 김영은  
시연 영상 편집 : 윤수윤(녹화는 각자)  
발표 자료 : [figma - CG_final_presentation](https://www.figma.com/file/8r9lhCqbeqjQodZk2wCTwW/CG_final_presentation?node-id=0%3A1&t=lhpsYwfeWatX9uaP-1)  
