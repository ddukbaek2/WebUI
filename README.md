# WebUI

## 개요
- 웹브라우저에서 동작하는 Desktop UI를 구현 하기 위한 프로젝트.
- 유니티 기반의 WebGL 빌드.


## 개발 스펙

### 테스트 페이지
- https://webui.ddukbaek2.com/

### 개발 환경
- Unity6 (6000.0.50f1)
- WebGL

### 사용 중인 유니티 패키지
- Unity UI

### 요청부터 실행까지 순서
1. 도메인 DNS 설정 (webui.ddukbaek2.com ==> 나스 NGINX 서버)
2. 나스의 메인 NGINX 서버로 넘어온 요청을 도커의 앱컨테이너로 리버스 프록시 연결.
3. 앱컨테이너의 NGINX에서 WebUI 서빙.

### 개발 방향
- Python3 기반의 Backend Server와 Unity6 기반의 Frontend Server로 웹브라우저 내의 GUI 환경 구축
- 두개의 프로젝트를 별도 구성하여 두 서버의 통신으로 처리되도록 구현 예정.
- 일단 현재 단계에서는 일단 프론트엔드에서 직접 보여질 수 있는 기능 위주로 더미 구현 예정.

### 도커 실행.
~~~bash
IMAGE_NAME=""
HOST_PORT=""
HOST_HOME_DIRECTORY=""
sudo docker run --rm --detach $IMAGE_NAME --publish $HOST_PORT:80\
 --volume $HOST_HOME_DIRECTORY:/usr/share/nginx/html/ nginx:alpine
~~~

## 이슈
### brotli 압축 지원 이슈
- 작성중
