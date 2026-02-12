# WPF Dynamic Layout Test Project

이 프로젝트는 WPF (`UniformGrid`)의 레이아웃을 사용자의 의도(Intent)에 따라 유연하게 제어하는 현대적인 UI 컴포넌트 예제입니다.

기존의 복잡한 "행/열 입력" 방식 대신, **차트 개수**와 **레이아웃 전략(Preset)**만 선택하면 자동으로 최적의 배치를 찾아주는 직관적인 UX를 제공합니다.

## ✨ 주요 기능 (Key Features)

### 1. 차트 개수 제어 (Chart Count Selector)
- 헤더의 `ComboBox`를 통해 **1개 ~ 6개**의 차트를 자유롭게 선택할 수 있습니다.
- 개수 변경 시 즉시 차트가 추가/제거되며, 현재 레이아웃 전략이 유지됩니다.

### 2. 의도 기반 레이아웃 프리셋 (Intent-based Layout Presets)
복잡한 행/열 계산 없이, 사용자가 "어떻게 보고 싶은지"를 선택하면 됩니다.
- **가로형 그리드 (Landscape Grid)**: 와이드 모니터에 최적화된 균형 잡힌 배치 (기본값).
- **세로형 그리드 (Portrait Grid)**: 좁은 화면이나 세로로 긴 창에 최적화.
- **세로 스택 (Vertical Stack)**: 스크롤 가능한 리스트 형태.
- **가로 스트립 (Horizontal Strip)**: 모든 차트를 한 줄로 비교 분석.

### 3. 직관적인 UI (Modern UI)
- **Direct Control**: 복잡한 팝업 없이 헤더의 **아이콘 버튼**을 클릭하여 즉시 레이아웃을 변경합니다.
- **Visual Feedback**: 현재 선택된 레이아웃이 하이라이트되며, 마우스 오버 시 한글 툴팁이 표시됩니다.
- **Easy Customization**: 아이콘이 `MainWindow.xaml`에 XAML 코드로 직접 정의되어 있어, 이미지나 아이콘 교체가 매우 쉽습니다.

## 🛠 기술 스택 (Tech Stack)
- **Framework**: .NET Framework 4.7.2
- **UI**: WPF (Windows Presentation Foundation)
- **Pattern**: Code-behind (Simple & Direct)

## 🚀 시작하기 (Getting Started)

1. 리포지토리를 클론합니다.
   ```bash
   git clone https://github.com/Peace-Min/LayoutTestProject.git
   ```
2. Visual Studio에서 `LayoutTestProject.sln` 솔루션 파일을 엽니다.
3. **F5**를 눌러 빌드 및 실행합니다.

## 📝 구조 (Structure)
- `MainWindow.xaml`: 메인 UI 및 레이아웃 정의 (Explicit XAML Controls)
- `ChartingControl.xaml`: 테스트용 더미 차트 컨트롤
- `DynamicGridTest`: 메인 프로젝트 폴더
